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
  selectedGarden: Garden;
  constructor(private gardenService: GardenService) { }

  ngOnInit() {
    this.getGardens();
  }

  onSelect(garden: Garden): void {
    this.selectedGarden = garden;
  }

  getGardens(): void {
    this.gardenService.getGardens()
      .subscribe(gardens => this.gardens = gardens);
  }

}
