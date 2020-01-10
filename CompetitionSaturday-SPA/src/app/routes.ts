import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { CompetitionListComponent } from './competition-list/competition-list.component';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
    { path: '', component: HomeComponent},
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            { path: 'competitions', component: CompetitionListComponent},
        ]
    },
    { path: '**', redirectTo: '', pathMatch: 'full'}
];
