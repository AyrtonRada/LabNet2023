import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
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


  constructor(private fb : FormBuilder,
     private router: Router,
      private employeesService : EmployeesService,
      private route: ActivatedRoute,
      private formBuilder: FormBuilder,
   ) { }

   employee! : EmployeeModel;
   formUpdateEmployees! : FormGroup;
   id: any = 0;


  ngOnInit(): void {

    this.formUpdateEmployees  = this.fb.group({
      id :[''],
      nombre : ['', [Validators.maxLength(10), Validators.required]],
      apellido : ['', [Validators.maxLength(20), Validators.required]]
    });

    let employeeId = this.route.snapshot.paramMap.get('id');
    this.employeesService.getEmployeeById(employeeId).subscribe( res => {
      this.employee = res;
      console.log(res)
      this.id = employeeId

      var data = this.employee;
      this.formUpdateEmployees.get('id')?.setValue(data.EmployeeID);
      this.formUpdateEmployees.get('nombre')?.setValue(data.FirstName);
      this.formUpdateEmployees.get('apellido')?.setValue(data.LastName);
    })

  }

  //Actualizar un empleado

  replaceEmployee(){
    try {

      let dataEmployees = new EmployeeModel();
      dataEmployees.EmployeeID = this.id;
      dataEmployees.FirstName = this.formUpdateEmployees.get('nombre')?.value;
      dataEmployees.LastName = this.formUpdateEmployees.get('apellido')?.value;
      console.log(this.id)
      let employeeId = this.route.snapshot.paramMap.get('id');
      this.employeesService.updateEmployee(dataEmployees, employeeId).subscribe( res=>{
        alert('Actualizado con Éxito!');
        this.router.navigate(['/']);
      })

    }catch (error) {
      console.log(error)
    }

  }

  //rediccion al home
  goToIndex() {
    this.router.navigate(['/']);
  }
}
