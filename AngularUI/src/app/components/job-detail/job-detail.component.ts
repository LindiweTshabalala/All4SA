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
  public userID: number = 0;
  public jobRequestID: number = 0;
  public amount: number = 0;

  constructor (
    public jobService: JobService,
    private route: ActivatedRoute,
  ) 
  { }

  ngOnInit(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.jobService.getJob(id)
      .subscribe( job => { this.job = job })
  }

  makeDonation(): void {
    this.userID = Number((<HTMLInputElement>document.getElementById("userID")).value);
    this.jobRequestID = Number((<HTMLInputElement>document.getElementById("userID")).value);
    this.amount = Number((<HTMLInputElement>document.getElementById("amount")).value);

    console.log(this.userID);
    console.log(this.jobRequestID);
    console.log(this.amount);
  }
}
