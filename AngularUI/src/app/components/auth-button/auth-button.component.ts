import { Component, Inject } from '@angular/core';
import { AuthService } from '@auth0/auth0-angular';
import { DOCUMENT } from '@angular/common';

@Component({
  selector: 'app-auth-button',
  template: `
    <ng-container *ngIf="auth.isAuthenticated$ | async; else loggedOut">
      <button (click)="auth.logout({ logoutParams: { returnTo: document.location.origin } })">
        Log out
      </button>
    </ng-container>

    <ng-template #loggedOut>
      <button (click)="logIn()">Log in</button>
    </ng-template>
  `,
  styles: [],
})
export class AuthButtonComponent {
  

  constructor(@Inject(DOCUMENT) public document: Document, public auth: AuthService) {}


  logIn(): void {
    this.auth.loginWithRedirect();

    this.auth.user$;
  }
}