import { Component, OnInit } from '@angular/core';
import { Garden } from '../models/garden';

@Component({
  selector: 'app-gardens',
  templateUrl: './gardens.component.html',
  styleUrls: ['./gardens.component.css']
})
export class GardensComponent implements OnInit {
  garden: Garden = {
    id: 1,
    name: 'back'
  };

  constructor() { }

  ngOnInit() {
  }

}
