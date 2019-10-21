import { Component, OnInit, Input } from '@angular/core';

import { Garden } from '../models/garden';
import { GardenService } from '../services/garden.service';

@Component({
    selector: 'app-garden-detail',
    templateUrl: './garden-detail.component.html',
    styleUrls: ['./garden-detail.component.css']
})
export class GardenDetailComponent implements OnInit {

    @Input() garden: Garden;

    constructor(private gardenService: GardenService) { }

    ngOnInit() {
    }

    save(): void {
        this.gardenService.updateGarden(this.garden).subscribe();
    }

}
