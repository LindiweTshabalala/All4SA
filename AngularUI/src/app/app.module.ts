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
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { PublicvotesComponent } from './components/publicvotes/publicvotes.component';

import { initializeApp, provideFirebaseApp } from '@angular/fire/app'
import { provideStorage, getStorage } from '@angular/fire/storage';
import { CreateJobComponent } from './components/create-job/create-job.component';
import { JobrequestApplyComponent } from './components/jobrequest-apply/jobrequest-apply.component'


@NgModule({
  declarations: [
    AppComponent,
    NavigationComponent,
    AuthButtonComponent,
    JobsComponent,
    JobDetailComponent,
    PublicvotesComponent,
    CreateJobComponent,
    JobrequestApplyComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule, 
    ReactiveFormsModule,
    provideFirebaseApp(() => initializeApp({
      apiKey: "AIzaSyDzD1QoKGUoGWb_CE0-CedJ8T3JUtSuPFc",
      authDomain: "all4sa-images.firebaseapp.com",
      projectId: "all4sa-images",
      storageBucket: "all4sa-images.appspot.com",
      messagingSenderId: "754356972480",
      appId: "1:754356972480:web:b7a060e56d995708457625",
      measurementId: "G-MSJ6QG2DR7"
    })),
    provideStorage(() => getStorage()),

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
