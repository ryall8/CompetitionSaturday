import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { JwtHelperService } from '@auth0/angular-jwt';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Competition } from '../_models/competition';

@Injectable({
  providedIn: 'root'
})
export class CompetitionService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getCompetitions(): Observable<Competition[]> {
    return this.http.get<Competition[]>(this.baseUrl + 'competitions/');
  }

  getCompetition(id): Observable<Competition> {
    return this.http.get<Competition>(this.baseUrl + 'competitions/' + id);
  }


}
