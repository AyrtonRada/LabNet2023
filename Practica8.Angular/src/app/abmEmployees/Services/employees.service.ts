import { Injectable } from '@angular/core';
import { Observable, BehaviorSubject } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { EmployeeModel } from '../Models/EmployeeModel';


@Injectable({
  providedIn: 'root'
})
export class EmployeesService {

  private endpoint : string = 'employees';
  private url = environment.api + this.endpoint;
  employee : EmployeeModel = new EmployeeModel();

  constructor(private http : HttpClient) { }

  // obtener la lista de empleados
  public listEmployee() : Observable<EmployeeModel[]>{
    return this.http.get<EmployeeModel[]>(this.url);
  }

  public insertEmployee( request : EmployeeModel) : Observable<any>{
    return this.http.post(this.url, request);
  }

  public deleteEmployee(id : number) : Observable<any>{
    return this.http.delete<EmployeeModel>(this.url + '/' + id);
  }

  getEmployeeById(id : number) : Observable<any>{
    return this.http.get(this.url + '/' + id);
  }

  updateEmployee(request : EmployeeModel, id : number) : Observable<any>{
    return this.http.put(this.url + '/' + id, request);
  }
}
