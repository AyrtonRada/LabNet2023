import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { EmployeeModel } from '../../Models/EmployeeModel';
import { EmployeesService } from '../../Services/employees.service';

@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.scss']
})
export class UpdateComponent implements OnInit {



  public formUpdateEmployees : FormGroup = this.fb.group({
    nombre : ['', [Validators.maxLength(10), Validators.required]],
    apellido : ['', [Validators.maxLength(20), Validators.required]]
  });

  constructor(private fb : FormBuilder,
     private router: Router,
      private employeesService : EmployeesService,
      private route: ActivatedRoute,
      private formBuilder: FormBuilder,
   ) { }

  ngOnInit(): void {

     this.employeesService.getEmployeeById(this.route.snapshot.params['id']).subscribe( res => {

      this.formUpdateEmployees.get('nombre')?.setValue(res.FirstName);
      this.formUpdateEmployees.get('apellido')?.setValue(res.LastName);

    })
  }

  //Actualizar un empleado

  replaceEmployee(){
    try {

      this.employeesService.updateEmployee(this.formUpdateEmployees.value, this.route.snapshot.params['id']).subscribe( res => {

        alert('Actualizado con Éxito!')
        this.router.navigate(['/']);
      })

    }catch (error) {
      console.log(error)
    }

  }

  //submit
  public enviarForm(){
    console.log(this.formUpdateEmployees.value)
  }

  //rediccion al home
  goToIndex() {
    this.router.navigate(['/']);
  }
}
