import { Component } from '@angular/core';
import { Job } from 'src/app/interfaces/job';
import { JobService } from 'src/app/services/job.service';

@Component({
  selector: 'app-jobs',
  templateUrl: './jobs.component.html',
  styleUrls: ['./jobs.component.css']
})
export class JobsComponent {
  jobs: Job[] = [];
  
  constructor(private jobService: JobService) {}

  ngOnInit() {
    this.jobService.getJobs()
      .subscribe(jobs => {this.jobs = jobs; console.log(this.jobs)});
  }
}
