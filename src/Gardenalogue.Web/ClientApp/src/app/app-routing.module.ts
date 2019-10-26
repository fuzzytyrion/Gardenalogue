import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GardensComponent } from './gardens/gardens.component';
import { GardenDetailComponent } from './garden-detail/garden-detail.component';

const routes: Routes = [
    { path: 'gardens', component: GardensComponent },
    { path: 'detail:id', component: GardenDetailComponent }
]


@NgModule({
    declarations: [],
    imports: [
        RouterModule.forRoot(routes)
    ],
    exports: [
        RouterModule
    ]
})
export class AppRoutingModule { }
