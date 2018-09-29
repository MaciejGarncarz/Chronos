import { Component, OnInit } from '@angular/core';
import { FinanceListService } from '../shared/financelist.service';
import { Response } from '@angular/http';
import { FinanceItem } from './finance-item.model';

@Component({
  selector: 'app-finance-list',
  templateUrl: './finance-list.component.html',
  styleUrls: ['./finance-list.component.css']
})
export class FinanceListComponent implements OnInit {
financeList: FinanceItem[];

  constructor(private financeListService: FinanceListService) {
    financeListService.getHttpList()
    .subscribe(
      (finances: FinanceItem[]) => {
      this.financeList = finances;
      },
      (error) => console.log(error)
    );
   }

  ngOnInit() {
  }

}
