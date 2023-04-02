import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.scss']
})
export class UpdateComponent implements OnInit {

  public formUpdateEmployees : FormGroup = this.fb.group({
    nombre : ['', [Validators.maxLength(10), Validators.required]],
    apellido : ['', [Validators.maxLength(20), Validators.required]]
  });

  constructor(private fb : FormBuilder, private router: Router) { }

  ngOnInit(): void {
  }

  public enviarForm(){
    console.log(this.formUpdateEmployees.value)
  }

  goToIndex() {
    this.router.navigate(['/']);
  }
}
