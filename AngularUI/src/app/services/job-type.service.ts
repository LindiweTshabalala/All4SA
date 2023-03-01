import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { JobType } from '../interfaces/jobType';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, count, map, tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class JobTypeService {

  url: string = 'https://localhost:7071';
  
  constructor(public http: HttpClient) { }

  getJobTypes(): Observable<JobType[]> {
    return this.http.get<JobType[]>(this.url+'/JobTypes')
    .pipe(
      tap((_) => console.log('fetched jobTypes')),
      catchError(this.handleError<JobType[]>('getUsers', []))
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
