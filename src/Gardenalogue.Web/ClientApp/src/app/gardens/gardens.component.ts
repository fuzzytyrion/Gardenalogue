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
    }

    getGardens(): void {
        this.gardenService.getGardens()
            .subscribe(gardens => this.gardens = gardens);
    }

    add(name: string): void {
        name = name.trim();
        if (!name) { return; }
        this.gardenService.addGarden({ name } as Garden)
            .subscribe(result => {
                this.getGardens();
            });
    }

    delete(garden: Garden): void {
        this.gardenService.deleteGarden(garden).subscribe(result => {
            this.getGardens();
        });
    }
}
