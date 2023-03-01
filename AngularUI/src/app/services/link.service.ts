import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, count, map, tap } from 'rxjs/operators';
import { Observable, of } from 'rxjs';
import { link } from '../interfaces/link';

@Injectable({
  providedIn: 'root'
})
export class LinkService {
  url: string = 'https://localhost:7071';

  constructor(private http: HttpClient) {}

  getImageByLink(link: string): Observable<link>{
    return this.http.get<link>(this.url+`/GetImageReferenceByLink/${link}`)
      .pipe(
        tap((_) => console.log('fetched Image by: '+link)),
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
