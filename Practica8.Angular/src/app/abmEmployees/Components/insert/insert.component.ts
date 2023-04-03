import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { EmployeeModel } from '../../Models/EmployeeModel';
import { EmployeesService } from '../../Services/employees.service';

@Component({
  selector: 'app-insert',
  templateUrl: './insert.component.html',
  styleUrls: ['./insert.component.scss'],
})
export class InsertComponent implements OnInit {
  public formEmployees: FormGroup = this.fb.group({
    nombre: ['', [Validators.maxLength(10), Validators.required]],
    apellido: ['', [Validators.maxLength(20), Validators.required]],
  });

  constructor(
    private fb: FormBuilder,
    private router: Router,
    private employeesService: EmployeesService
  ) {}

  ngOnInit(): void {}

  saveEmployee() {
    //agregar un empleado

    try {
      var employee = new EmployeeModel();
      employee.FirstName = this.formEmployees.get('nombre')?.value;
      employee.LastName = this.formEmployees.get('apellido')?.value;
      this.employeesService.insertEmployee(employee).subscribe((res) => {
        this.formEmployees.reset();
        alert('Creado con Éxito!');
        this.router.navigate(['/']);
      });
    } catch (error) {
      console.log(error);
    }
  }

  goToIndex() {
    this.router.navigate(['/']);
  }
}
