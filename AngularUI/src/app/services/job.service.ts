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
    return this.http.get<Job[]>(this.url+'/JobRequestDetails')
      .pipe(
        tap((_) => console.log('fetched JobRequestDetails')),
        catchError(this.handleError<Job[]>('getJobs', []))
      );
  }

  getJob(id: number): Observable<Job> {
    return this.http.get<Job>(this.url+'/JobRequestDetails/GetJobRequestDetailsByID/'+id)
      .pipe(
        tap((_) => console.log('fetched JobRequest: '+id)),
      );
  }  

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // TODO: better job of transforming error for user consumption
      console.log(`${operation} failed: ${error.message}`);

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }
}
