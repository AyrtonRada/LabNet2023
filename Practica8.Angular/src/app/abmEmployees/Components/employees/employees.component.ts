import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EmployeeModel } from '../../Models/EmployeeModel';
import { EmployeesService } from '../../Services/employees.service';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.scss']
})
export class EmployeesComponent implements OnInit {

  public employeeList : EmployeeModel[] = [];
  constructor(private router : Router, private employeesService : EmployeesService) { }
  ngOnInit(): void {

    //obtener lista de empleados
    try {
      this.employeesService.listEmployee().subscribe( res => {
        this.employeeList = res;
      })
    } catch (error) {
      console.log(error)
    }
  }

  //actualizar un empleado

  getEmployeeById( id: number){
    let currentEmployee = this.employeeList.find( x => { return x.EmployeeID === id})
    console.log(currentEmployee)
  }

  //Eliminar un empleado

  eraseEmployee( id : number){
    try {
      this.employeesService.deleteEmployee(id).subscribe( res => {
        location.reload();
      });
    } catch (error) {
      console.log(error)
    }
  }

  // navegar entre componentes
  goToInsert() {
    this.router.navigate(['/insert']);
  }

  goToUpdate(id : number) {
    this.router.navigate(['/update'+ '/' + id]);
  }


}
