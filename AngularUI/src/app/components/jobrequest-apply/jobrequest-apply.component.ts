import { Component } from '@angular/core';
import { AuthService } from '@auth0/auth0-angular';
import { Router } from '@angular/router';
import { UserService } from 'src/app/services/user.service';
import { ActivatedRoute } from '@angular/router';
import { User } from 'src/app/interfaces/user';
import { PublicvotesService } from 'src/app/services/publicvotes.service';


@Component({
  selector: 'app-jobrequest-apply',
  templateUrl: './jobrequest-apply.component.html',
  styleUrls: ['./jobrequest-apply.component.css']
})
export class JobrequestApplyComponent {
  user: User = {
    userID: 0,
    firstName: "",
    surname: "",
    idNumber: "",
    token: "",
    isDeleted: false
  };

  jobRequestID = Number(this.route.snapshot.paramMap.get('id'));

  constructor(private route: ActivatedRoute,
    public auth: AuthService,
    private publicvotesService: PublicvotesService,
    private userService: UserService,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.auth.user$
      .subscribe((authUser) => {

        this.user = {
          userID: 0,
          firstName: authUser?.name?.split(" ")[0],
          surname: authUser?.family_name,
          idNumber: '0000000000000',
          token: authUser?.sub,
          isDeleted: false
        }
        console.log("JOB APPLICATION")
      });
  }

  async applyUserToJob() {
    this.jobRequestID = Number(this.route.snapshot.paramMap.get('id'));
    console.log("Before")

    await this.userService.getUserByToken(this.user.token).toPromise()
      .then(result => this.user = result as User)

    console.log("After: " + this.user.userID)
    this.publicvotesService.addToPublicVotes(this.user.userID, this.jobRequestID)

    this.router.navigate([''], { replaceUrl: true });
  }
}
