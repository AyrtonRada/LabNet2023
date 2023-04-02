import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmployeesComponent } from './abmEmployees/Components/employees/employees.component';
import { InsertComponent } from './abmEmployees/Components/insert/insert.component';
import { UpdateComponent } from './abmEmployees/Components/update/update.component';

const routes: Routes = [
  {
    path: '',
    component: EmployeesComponent
  },{
    path: 'insert',
    component: InsertComponent
  },{
    path: 'update',
    component: UpdateComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
