import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-insert',
  templateUrl: './insert.component.html',
  styleUrls: ['./insert.component.scss']
})
export class InsertComponent implements OnInit {

  public formEmployees : FormGroup = this.fb.group({
    nombre : [''],
    apellido : ['']
  });

  constructor(private fb : FormBuilder) { }

  ngOnInit(): void {
  }

  public enviarForm(){
    console.log(this.formEmployees.value)
  }

}
