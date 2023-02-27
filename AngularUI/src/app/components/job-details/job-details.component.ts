import { Component } from '@angular/core';
import { Job } from 'src/app/interfaces/job';

@Component({
  selector: 'app-job-details',
  templateUrl: './job-details.component.html',
  styleUrls: ['./job-details.component.css']
})
export class JobDetailsComponent {
  job? : Job;

  ngOnInit(): void {
    this.job = {
      JobRequestID: 1,
      JobRequestDescription: 'Description',
      UserID: 1,
      ImageReferenceID: 'https://cdn.pixabay.com/photo/2023/02/05/17/25/leaves-7770035_960_720.jpg',
      JobTypeID: 0,
      EstimatedCost: 200,
      Status: 0
    }
  }

}
