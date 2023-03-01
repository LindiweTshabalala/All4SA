import { Component } from '@angular/core';
import { JobType } from 'src/app/interfaces/jobType';
import { JobTypeService } from 'src/app/services/job-type.service';

@Component({
  selector: 'app-create-job',
  templateUrl: './create-job.component.html',
  styleUrls: ['./create-job.component.css']
})
export class CreateJobComponent {
  public file: any = {};
  jobTypes: JobType[] = [];

  constructor(public jobTypeService: JobTypeService) {}

  calculateEstimateAmount(): void {
    //make it recevie amount
  }

  chooseFile(event: any): void {
    this.file = event.target.file[0];
  }

  uploadImage(): void {
    // TODO: 
  } 

  ngOnInit () {
    this.jobTypeService.getJobTypes()
      .subscribe(l => console.log(l));
  }
}
