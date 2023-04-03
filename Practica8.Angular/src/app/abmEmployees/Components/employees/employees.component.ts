import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EmployeeModel } from '../../Models/EmployeeModel';
import { EmployeesService } from '../../Services/employees.service';
import Swal from 'sweetalert2';


@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.scss'],
})
export class EmployeesComponent implements OnInit {
  public employeeList: EmployeeModel[] = [];
  constructor(
    private router: Router,
    private employeesService: EmployeesService
  ) {}
  ngOnInit(): void {
    //obtener lista de empleados
    try {
      this.employeesService.listEmployee().subscribe((res) => {
        this.employeeList = res;
      });
    } catch (error) {
      console.log(error);
    }
  }

  //Eliminar un empleado

  eraseEmployee(id: number) {
    try {
       {
        this.swalWithBootstrapButtons(id);
      };
    } catch (error) {
      console.log(error);
    }
  }

  // navegar entre componentes
  goToInsert() {
    this.router.navigate(['/insert']);
  }

  goToUpdate(id: number) {
    this.router.navigate(['update', id]);
  }

  //alerta de confirmacion
  swalWithBootstrapButtons(id : number): void {
    const swal = Swal.mixin({
      customClass: {
        confirmButton: 'btn btn-success',
        cancelButton: 'btn btn-danger'
      },
      buttonsStyling: false
    });

    swal.fire({
      title: '¿Estás seguro?',
      text: 'No podrás revertir esto',
      icon: 'warning',
      showCancelButton: true,
      confirmButtonText: 'Sí, borrar',
      cancelButtonText: 'Cancelar',
      reverseButtons: true

    }).then((result) => {
      if (result.isConfirmed) {
        this.employeesService.deleteEmployee(id).subscribe((res) =>{

          swal.fire(
            '¡Borrado!',
            'Empleado eliminado.'
          );
          setTimeout(()=>{
            location.reload();
        }, 2000);

        })
      }else if (
        result.dismiss === Swal.DismissReason.cancel
      ) {
        swal.fire(
          'Eliminación Cancelada'
        )
      }
    });
  }

}
