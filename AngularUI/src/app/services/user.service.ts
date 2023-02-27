import { Injectable } from '@angular/core';
import { User } from '../interfaces/user';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, count, map, tap } from 'rxjs/operators';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  url: string = 'https://localhost:7071';
  users: User[] = [];
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' }),
  };

  constructor(private http: HttpClient) {}

  getUsers(): Observable<User[]> {
    return this.http.get<User[]>(this.url+'/Users')
    .pipe(
      tap((_) => console.log('fetched Users')),
      catchError(this.handleError<User[]>('getUsers', []))
    );
  }

  createUser(user: User): Observable<User> {
    if (this.users.some(el => el.token === user.token) || user.firstName === undefined) {
      return new Observable<User>;
    }

    console.log("Creating user: ");
    console.log(user)

    return this.http.post<User>(this.url+"/Users/AddUser", user, this.httpOptions)
      .pipe(
        tap((_) => console.log('Created user'))
      )
  }

  ngOnInit(): void {
    this.getUsers()
      .subscribe(users => this.users = users);
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
