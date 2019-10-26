import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

import { Garden } from '../models/garden';
import { GardenService } from '../services/garden.service';

@Component({
    selector: 'app-garden-detail',
    templateUrl: './garden-detail.component.html',
    styleUrls: ['./garden-detail.component.css']
})
export class GardenDetailComponent implements OnInit {

    @Input() garden: Garden;

    constructor(
        private route: ActivatedRoute,
        private gardenService: GardenService,
        private location: Location
    ) { }

    ngOnInit(): void {
        this.getGarden();
    }

    getGarden(): void {
        const id = +this.route.snapshot.paramMap.get('id');
        this.gardenService.getGarden(id)
            .subscribe(garden => this.garden = garden);
    }

    save(): void {
        this.gardenService.updateGarden(this.garden).subscribe();
    }

}
