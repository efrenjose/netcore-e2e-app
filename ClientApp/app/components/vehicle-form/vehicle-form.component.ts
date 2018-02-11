import { MakeService } from './../../services/make.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {

   makes: string[] = [];

  constructor(private MakeService: MakeService) { }

  ngOnInit() {
    this.MakeService.getMakes().subscribe(makes => {
      this.makes = makes;
      console.log("MAKES", this.makes);
      
    });

  }

}
