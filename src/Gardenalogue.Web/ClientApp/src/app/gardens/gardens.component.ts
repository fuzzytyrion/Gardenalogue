import { Component, OnInit } from '@angular/core';
import { Garden } from '../models/garden';
import { GardenService } from '../services/garden.service';

@Component({
  selector: 'app-gardens',
  templateUrl: './gardens.component.html',
  styleUrls: ['./gardens.component.css']
})
export class GardensComponent implements OnInit {
  gardens: Garden[];

  constructor(private gardenService: GardenService) { }

  ngOnInit() {
    this.getGardens();
    console.log(JSON.stringify(this.gardens, undefined, 2))
  }

  getGardens(): void {
    console.log('bebbo');
    this.gardenService.getGardens()
      .subscribe(gardens => this.gardens = gardens);
  }

}
