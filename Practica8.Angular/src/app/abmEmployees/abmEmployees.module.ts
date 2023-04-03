import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeesComponent } from './Components/employees/employees.component';
import { InsertComponent } from './Components/insert/insert.component';
import { ReactiveFormsModule } from '@angular/forms';
import { UpdateComponent } from './Components/update/update.component';
import { HttpClientModule } from '@angular/common/http';



@NgModule({
  declarations: [
    EmployeesComponent,
    InsertComponent,
    UpdateComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    HttpClientModule
  ]
})
export class AbmEmployeesModule { }
