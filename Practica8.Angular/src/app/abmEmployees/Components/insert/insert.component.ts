import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-insert',
  templateUrl: './insert.component.html',
  styleUrls: ['./insert.component.scss']
})
export class InsertComponent implements OnInit {

  public formEmployees : FormGroup = this.fb.group({
    nombre : ['', [Validators.maxLength(10), Validators.required]],
    apellido : ['', [Validators.maxLength(20), Validators.required]]
  });

  constructor(private fb : FormBuilder) { }

  ngOnInit(): void {
  }

  public enviarForm(){

  }

}
