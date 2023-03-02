import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AuthService } from '@auth0/auth0-angular';
import { Job } from 'src/app/interfaces/job';
import { JobService } from 'src/app/services/job.service';
import { UserService } from 'src/app/services/user.service';

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
    public route: ActivatedRoute,
    public uesrService: UserService,
    public auth: AuthService
  ) 
  { }

  ngOnInit(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.jobService.getJob(id)
      .subscribe( job => { this.job = job })
  }

  makeDonation(): void {
    this.auth.user$
      .subscribe(authUser => {
        alert("Thank you " + authUser?.name + " for your donation");
      });                                                                                                            
  }
}
