import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpModule} from '@angular/http';

import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { FinanceListComponent } from './finance-list/finance-list.component';
import { FinanceListService } from './shared/financelist.service';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    FinanceListComponent
  ],
  imports: [
    BrowserModule,
    HttpModule
  ],
  providers: [FinanceListService],
  bootstrap: [AppComponent]
})
export class AppModule { }
