import { Injectable } from "@angular/core";
import { Http, Response } from "@angular/http";
import { map } from 'rxjs/operators';
import { FinanceItem } from "../finance-list/finance-item.model";

@Injectable()
export class FinanceListService {
    constructor(private http: Http) {

    }
    getList() {
        return tempArray;
        //TODO2 Jak sie uda pobrac dane to przerobic pozniej na nowy spposob(Najlepiej zrozumiec 2 sposoby)
    }

    getHttpList(){
        return this.http.get('http://localhost:52016/api/FinanceItems')
        .pipe(
            map(
                (response: Response) => {
                    const data = response.json();
                    return data;
                }
            )
        )

    }
}

const tempArray = [
    {
        id: '1',
        name: 'Studia',
        price: 300
    },
    {
        id: 2,
        name: 'Kredyt',
        price: 300
    }
]