import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule} from '@angular/forms';
import { HttpModule} from '@angular/http';
import { Routes, RouterModule} from '@angular/router';

import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { FinanceListComponent } from './finance-list/finance-list.component';
import { FinanceListService } from './shared/financelist.service';
import { PlansComponent } from './plans/plans.component';

const appRoutes: Routes = [
  {path: '', component: FinanceListComponent},
  {path: 'plans', component: PlansComponent}
  //{path: 'plans', component: PlansComponent}
];

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    FinanceListComponent,
    PlansComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [FinanceListService],
  bootstrap: [AppComponent]
})
export class AppModule { }
