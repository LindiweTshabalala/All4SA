import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AuthModule } from '@auth0/auth0-angular';
import { HttpClientModule } from '@angular/common/http';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavigationComponent } from './components/navigation/navigation.component';
import { AuthButtonComponent } from './components/auth-button/auth-button.component';
import { JobsComponent } from './components/jobs/jobs.component';
import { JobDetailComponent } from './components/job-detail/job-detail.component';

@NgModule({
  declarations: [
    AppComponent,
    NavigationComponent,
    AuthButtonComponent,
    JobsComponent,
    JobDetailComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule, 

    AuthModule.forRoot({
      domain: 'dev-2wnu2oln5iyh7vpe.us.auth0.com',
      clientId: '2hXQ8UOHX2OF2qoYDEdT8UojPEYYbxS2',
      authorizationParams: {
        redirect_uri: window.location.origin
      }
    })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
