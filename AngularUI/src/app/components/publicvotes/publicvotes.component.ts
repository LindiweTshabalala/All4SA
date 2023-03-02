import { Component } from '@angular/core';
import { PublicVote } from 'src/app/interfaces/publicVote';
import { Router } from '@angular/router';
import { UserService } from 'src/app/services/user.service';
import { PublicvotesService } from 'src/app/services/publicvotes.service';
import { User } from '../../interfaces/user';

@Component({
  selector: 'app-publicvotes',
  templateUrl: './publicvotes.component.html',
  styleUrls: ['./publicvotes.component.css']
})
export class PublicvotesComponent {
  publicVotes: PublicVote[] = [];
  user: User = {
      userID: 0,
      firstName: "",
      surname: "",
      idNumber: "",
      token: "",
      isDeleted: false
  }

  constructor(private publicVotesService: PublicvotesService,
    private router: Router,
    private userService: UserService,) { }

  ngOnInit() {
    this.publicVotesService.getPublicVotes()
      .subscribe(publicVotes => this.publicVotes = publicVotes);
    console.log(this.publicVotes)
  }

  async upVoteUser(publicVote: PublicVote) {
    //await this.userService.getUserByToken(this.user.token).toPromise()
    //  .then(result => this.user = result as User)
    let requestingUserID = 0;
    console.log("jobRequestID: " + publicVote.jobRequestID)
    console.log("name: " + publicVote.firstName)
    console.log("surname: " + publicVote.surname)

    this.userService.getUserID(publicVote.firstName, publicVote.surname).subscribe(
      userID => {
        requestingUserID = userID;
        console.log("requestingUserID: " + requestingUserID)
        this.publicVotesService.upVote(publicVote.jobRequestID, requestingUserID)
      }
    )
    
    this.router.navigate([''], { replaceUrl: true });
  }
}
