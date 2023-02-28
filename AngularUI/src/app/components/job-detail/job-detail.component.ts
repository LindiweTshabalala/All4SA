import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Job } from 'src/app/interfaces/job';
import { JobService } from 'src/app/services/job.service';

@Component({
  selector: 'app-job-detail',
  templateUrl: './job-detail.component.html',
  styleUrls: ['./job-detail.component.css']
})
export class JobDetailComponent {
  job?: Job;

  constructor (
    public jobService: JobService,
    private route: ActivatedRoute
  ) 
  {}

  ngOnInit(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.jobService.getJob(id)
      .subscribe( job => { this.job = job })
  }

  makeDonation(): void {
    
  }
}
