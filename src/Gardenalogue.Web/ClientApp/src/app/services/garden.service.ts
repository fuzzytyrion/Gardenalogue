import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { Garden } from '../models/garden';

@Injectable({ providedIn: 'root' })
export class GardenService {

  private gardensUrl = 'https://localhost:44337/api/Gardens';  // URL to web api

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  constructor(private http: HttpClient) { }

  getGardens(): Observable<Garden[]> {
    return this.http.get<Garden[]>(this.gardensUrl);
  }

}
