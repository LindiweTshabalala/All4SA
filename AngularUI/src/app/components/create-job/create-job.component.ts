import { Component } from '@angular/core';
import { AuthService } from '@auth0/auth0-angular';
import { JobType } from 'src/app/interfaces/jobType';
import { JobTypeService } from 'src/app/services/job-type.service';
import { UserService } from 'src/app/services/user.service';
import { Storage, ref, uploadBytesResumable, getDownloadURL } from '@angular/fire/storage'
import { LinkService } from 'src/app/services/link.service';

@Component({
  selector: 'app-create-job',
  templateUrl: './create-job.component.html',
  styleUrls: ['./create-job.component.css']
})
export class CreateJobComponent {
  public file: any = {};
  jobTypes: JobType[] = [];
  jobTypeID: number = 1;
  estimatedAmount: number = 0;
  pictureUrl: string = "";
  userID: number = 0;
  

  constructor(
    public jobTypeService: JobTypeService,
    public userServie: UserService,
    public auth: AuthService,
    public storage: Storage,
    public linkService: LinkService
  ) {}

  calculateEstimateAmount(): void {
    let jobTypeName: string = (<HTMLInputElement>document.getElementById("jobType")).value

    let jobType: JobType = this.jobTypes.filter(n => n.jobTypeName === jobTypeName)[0];
    
    this.jobTypeID = jobType.jobTypeID;
    
    let hours: number = 8;
    let days: number = 5;

    this.estimatedAmount = hours * days * jobType.hourlyRate;

    console.log(this.estimatedAmount);
  }

  chooseFile(event: any): void {
    this.file = event.target.files[0];
  }

  uploadImage(): void {
    const storageRef = ref(this.storage, this.file.name);
    const uploadTask = uploadBytesResumable(storageRef, this.file);
    uploadTask.on('state_changed',
      (snapshot) => {
        const progress = (snapshot.bytesTransferred / snapshot.totalBytes) * 100;
        console.log('Upload is ' + progress + '% done');
      },
      (error) =>{},
      () => {
        getDownloadURL(uploadTask.snapshot.ref).then((downloadURL) => {
          console.log('File available at', downloadURL);
          this.pictureUrl = downloadURL
        });
      }
    );
  } 
  
  createJobRequest(): void {
    this.linkService.getImageByLink(this.pictureUrl)
      .subscribe(link => console.log(link));
  }
  
  ngOnInit () {
    this.jobTypeService.getJobTypes()
      .subscribe(jobTypes => this.jobTypes = jobTypes);

    this.auth.user$
      .subscribe(user => this.userServie.getUserByToken(user?.sub)
        .subscribe(loggedInUser => this.userID = loggedInUser.userID))
  }
}
