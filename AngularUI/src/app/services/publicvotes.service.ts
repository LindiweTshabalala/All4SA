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
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' }),
  };
 
  constructor(private http: HttpClient) { }
  
  getPublicVotes(): Observable<PublicVote[]> {
    return this.http.get<PublicVote[]>(this.url +"/UserJobApplication")
      .pipe(
        tap((_) => console.log('fetched All Public Votes')),
        catchError(this.handleError<PublicVote[]>('GetAllUserJobApplications', []))
      );
  }

  upVote(jobRequestID: number, userID: number) {
    fetch(this.url + `/UserJobApplication/UpvoteByUserID/${jobRequestID}/${userID}`, {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json'
      },
    })
      .then(response => {
        if (!response.ok) {
          throw new Error('Network response was not ok');
        }
        console.log("Upvoted User With ID " + userID)
        return response.json();
      })
      .then(data => { console.log("dataResponse:"); console.log(data) })
      .catch(error => console.error("error: " + error));
  }

  downVote(jobRequestID: number, userID: number) {
    fetch(this.url + `/UserJobApplication/DownvoteByUserID/${jobRequestID}/${userID}`, {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json'
      },
    })
      .then(response => {
        if (!response.ok) {
          throw new Error('Network response was not ok');
        }
        console.log("Upvoted User With ID " + userID)
        return response.json();
      })
      .then(data => { console.log("dataResponse:"); console.log(data) })
      .catch(error => console.error("error: " + error));
  }

  addToPublicVotes(user_ID: number, jobRequestID: number): void {
    let data = {
      userID: user_ID
    };

    fetch(this.url + `/UserJobApplication/AddUserJobApplication/${jobRequestID}/${user_ID}`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(data)
    })
      .then(response => {
        if (!response.ok) {
          throw new Error('Network response was not ok');
        }
        console.log("Added User To Public Vote Table")
        return response.json();
      })
      .then(data => { console.log("dataResponse:"); console.log(data) })
      .catch(error => console.error("error: " + error));
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
