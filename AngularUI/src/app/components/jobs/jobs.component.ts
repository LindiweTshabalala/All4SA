import { Component } from '@angular/core';
import { Job } from 'src/app/interfaces/job';

@Component({
  selector: 'app-jobs',
  templateUrl: './jobs.component.html',
  styleUrls: ['./jobs.component.css']
})
export class JobsComponent {
  jobs: Job[] = [];
  
  
  ngOnInit() {
    let job: Job = {
      JobRequestID: 1,
      JobRequestDescription: 'Description',
      UserID: 1,
      ImageReferenceID: 'https://cdn.pixabay.com/photo/2023/02/05/17/25/leaves-7770035_960_720.jpg',
      JobTypeID: 0,
      EstimatedCost: 200,
      Status: 'done'
    }
      
    this.jobs.push(job);
  }
}
