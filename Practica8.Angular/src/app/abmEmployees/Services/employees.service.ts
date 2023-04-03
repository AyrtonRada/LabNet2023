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

  constructor(private http : HttpClient) { }

  // obtener la lista de empleados
  listEmployee() : Observable<EmployeeModel[]>{
    return this.http.get<EmployeeModel[]>(environment.api + this.endpoint);
  }

  public insertEmployee( request : EmployeeModel) : Observable<any>{
    let url = environment.api + this.endpoint;
    return this.http.post(url, request);
  }
}
