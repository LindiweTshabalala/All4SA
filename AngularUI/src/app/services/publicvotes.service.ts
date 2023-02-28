import { Injectable } from '@angular/core';
import { PublicVote } from '../interfaces/publicVote';

import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, count, map, tap } from 'rxjs/operators';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PublicvotesService {
  url: string = 'https://localhost:7071';

  constructor(private http: HttpClient) { }

  getPublicVotes(): Observable<PublicVote[]> {
    return this.http.get<PublicVote[]>(this.url + '/PublicVotes')
      .pipe(
        tap((_) => console.log('fetched All Public Votes')),
        catchError(this.handleError<PublicVote[]>('getPublicVotes', []))
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
