import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeesComponent } from './Components/employees/employees.component';
import { InsertComponent } from './Components/insert/insert.component';



@NgModule({
  declarations: [
    EmployeesComponent,
    InsertComponent
  ],
  imports: [
    CommonModule
  ]
})
export class AbmEmployeesModule { }
