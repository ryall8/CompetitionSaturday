import { Component, OnInit } from '@angular/core';
import { Competition } from '../../_models/competition';
import { CompetitionService } from '../../_services/competition.service';
import { AlertifyService } from '../../_services/alertify.service';

@Component({
  selector: 'app-competition-list',
  templateUrl: './competition-list.component.html',
  styleUrls: ['./competition-list.component.css']
})
export class CompetitionListComponent implements OnInit {
  competitions: Competition[];

  constructor(private competitionService: CompetitionService, private alertify: AlertifyService) { }

  ngOnInit() {
    this.loadUsers();
  }

  loadUsers() {
    this.competitionService.getCompetitions().subscribe((competitions: Competition[]) => {
      this.competitions = competitions;
    }, error => {
      this.alertify.error(error);
    });
  }
}
