import { Injectable } from '@angular/core';
import { Job } from '../interfaces/job';

import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, count, map, tap } from 'rxjs/operators';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class JobService {
  url: string = 'https://localhost:7071';

  constructor(private http: HttpClient) {}

  getJobs(): Observable<Job[]> {
    return this.http.get<Job[]>(this.url)
      .pipe(
        tap((_) => console.log('fetched Users')),
        catchError(this.handleError<User[]>('getUsers', []))
      );
  }
}
