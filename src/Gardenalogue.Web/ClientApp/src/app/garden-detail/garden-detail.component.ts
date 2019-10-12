import { Component, OnInit, Input } from '@angular/core';

import { Garden } from '../models/garden';

@Component({
  selector: 'app-garden-detail',
  templateUrl: './garden-detail.component.html',
  styleUrls: ['./garden-detail.component.css']
})
export class GardenDetailComponent implements OnInit {

  @Input() garden: Garden;

  constructor() { }

  ngOnInit() {
  }

}
