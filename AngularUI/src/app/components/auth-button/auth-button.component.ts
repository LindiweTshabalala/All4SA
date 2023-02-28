import { Component, Inject } from '@angular/core';
import { AuthService } from '@auth0/auth0-angular';
import { DOCUMENT } from '@angular/common';
import { UserService } from 'src/app/services/user.service';
import { User } from 'src/app/interfaces/user';

@Component({
  selector: 'app-auth-button',
  templateUrl: './auth-button.component.html',
  styles: [],
})
export class AuthButtonComponent {
  user: User = {
    userID: 0,
    firstName: "",
    surname: "",
    idNumber: "",
    token: "" 
  };  

  constructor(
    private userService: UserService,
    @Inject(DOCUMENT) public document: Document, 
    public auth: AuthService
  ) {}


  ngOnInit(): void {
    this.auth.user$
      .subscribe((authUser) => {

        console.log(authUser)

        this.user = {
          userID: 0,
          firstName: authUser?.name?.split(" ")[0],
          surname: authUser?.family_name,
          idNumber: '0000000000000',
          token: authUser?.sub 
        }
        
        
        this.userService.createUser(this.user);
      });  

  }

  logIn(): void {
    this.auth.loginWithRedirect();
  }
}