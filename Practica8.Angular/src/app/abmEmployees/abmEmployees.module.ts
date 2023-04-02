import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeesComponent } from './Components/employees/employees.component';
import { InsertComponent } from './Components/insert/insert.component';
import { ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    EmployeesComponent,
    InsertComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule
  ]
})
export class AbmEmployeesModule { }
