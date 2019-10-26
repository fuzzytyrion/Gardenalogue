import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { Garden } from '../models/garden';

@Injectable({ providedIn: 'root' })
export class GardenService {

    private gardensUrl = 'https://localhost:44336/api/Gardens';  // URL to web api

    httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };

    constructor(private http: HttpClient) { }

    getGardens(): Observable<Garden[]> {
        return this.http.get<Garden[]>(this.gardensUrl);
    }

    getGarden(id: number): Observable<Garden> {
        const url = `${this.gardensUrl}/${id}`;

        return this.http.get<Garden>(url, this.httpOptions);
    }

    updateGarden(garden: Garden): Observable<any> {
        return this.http.put(this.gardensUrl, garden, this.httpOptions);
    }

    addGarden(garden: Garden): Observable<Garden> {
        return this.http.post<Garden>(this.gardensUrl, garden, this.httpOptions);
    }

    deleteGarden(garden: Garden | number): Observable<Garden> {
        const id = typeof garden === 'number' ? garden : garden.id;
        const url = `${this.gardensUrl}/${id}`;

        return this.http.delete<Garden>(url, this.httpOptions);
    }
}
