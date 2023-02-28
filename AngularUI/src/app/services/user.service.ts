import { Injectable } from '@angular/core';
import { User } from '../interfaces/user';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, count, map, tap } from 'rxjs/operators';
import { Observable, of } from 'rxjs';
import { Token } from '@angular/compiler';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  url: string = 'https://localhost:7071';
  users: User[] = [];
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' }),
  };

  constructor(private http: HttpClient) { }

  getUsers(): Observable<User[]> {
    return this.http.get<User[]>(this.url+'/Users')
    .pipe(
      tap((_) => console.log('fetched Users')),
      catchError(this.handleError<User[]>('getUsers', []))
    );
  }

  createUser(user: User): void {
    console.log("Creating user: ");
    console.log(user)

    fetch(this.url+`/Users/AddUser/${user.firstName}/${user.surname}/${user.token}`)
      .then((response) => response.json())
      .then((data) => console.log(data));


    // return this.http.get<User>(this.url+`/Users`)
    //   .pipe(
    //     tap((_) => console.log('Created user'))
    //   );
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error(error); 

      console.log(`${operation} failed: ${error.message}`);

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }
}
