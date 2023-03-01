import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateJobComponent } from './components/create-job/create-job.component';
import { JobDetailComponent } from './components/job-detail/job-detail.component';
import { JobsComponent } from './components/jobs/jobs.component';



const routes: Routes = [
  { path: '', redirectTo: 'jobs', pathMatch: 'full' },
  { path: 'detail/:id', component: JobDetailComponent },
  { path: 'jobs', component: JobsComponent},
  { path: 'create', component: CreateJobComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
