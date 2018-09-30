import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-plans',
  templateUrl: './plans.component.html',
  styleUrls: ['./plans.component.css']
})
export class PlansComponent implements OnInit {
  //This is temp object
  plan = {
    name: '',
    expirationDate: '',
    repeater: '',
    budget: ''
  }

  constructor() { }

  ngOnInit() {
  }

  onSubmit(form: NgForm)
  {
    this.plan.name = form.value.name;
    this.plan.expirationDate = form.value.expirationDate;
    this.plan.repeater = form.value.repeater;
    this.plan.budget = form.value.budget;

    console.log(this.plan);

    form.reset();
  }

  onReset(form: NgForm){
    form.reset();
  }

}
