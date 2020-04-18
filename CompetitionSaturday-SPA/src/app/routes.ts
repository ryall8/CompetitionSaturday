import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { CompetitionListComponent } from './competitions/competition-list/competition-list.component';
import { AuthGuard } from './_guards/auth.guard';
import { CompetitionDetailComponent } from './competitions/competition-detail/competition-detail.component';

export const appRoutes: Routes = [
    { path: '', component: HomeComponent},
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            { path: 'competitions', component: CompetitionListComponent},
            { path: 'competitions/:id', component: CompetitionDetailComponent}
        ]
    },
    { path: '**', redirectTo: '', pathMatch: 'full'}
];
