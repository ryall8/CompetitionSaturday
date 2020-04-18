import { Component, OnInit } from '@angular/core';
import { CompetitionService } from 'src/app/_services/competition.service';
import { Competition } from 'src/app/_models/competition';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-competition-detail',
  templateUrl: './competition-detail.component.html',
  styleUrls: ['./competition-detail.component.css']
})
export class CompetitionDetailComponent implements OnInit {
  competition: Competition;

  constructor(private competitionService: CompetitionService, 
              private alertify: AlertifyService, 
              private route: ActivatedRoute) { }

  ngOnInit() {
    this.loadCompetition();
  }

  loadCompetition() {
    this.competitionService.getCompetition(+this.route.snapshot.params['id']).subscribe((competition: Competition) => {
      this.competition = competition;
    }, error => {
      this.alertify.error(error);
    })
  }

}
