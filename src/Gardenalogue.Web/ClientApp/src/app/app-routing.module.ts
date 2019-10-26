import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GardensComponent } from './gardens/gardens.component';

const routes: Routes = [
    { path: 'gardens', component: GardensComponent }
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
