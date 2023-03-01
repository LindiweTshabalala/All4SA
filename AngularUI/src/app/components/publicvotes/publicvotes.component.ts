import { Component } from '@angular/core';
import { PublicVote } from 'src/app/interfaces/publicVote';
import { PublicvotesService } from 'src/app/services/publicvotes.service';

@Component({
  selector: 'app-publicvotes',
  templateUrl: './publicvotes.component.html',
  styleUrls: ['./publicvotes.component.css']
})
export class PublicvotesComponent {
  publicVotes: PublicVote[] = [];

  constructor(private publicVotesService: PublicvotesService) { }

  ngOnInit() {
    this.publicVotesService.getPublicVotes()
      .subscribe(publicVotes => this.publicVotes = publicVotes);
    console.log(this.publicVotes)
  }
}
