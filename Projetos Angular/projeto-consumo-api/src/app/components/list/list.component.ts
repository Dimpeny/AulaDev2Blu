import { Subject, Observable } from 'rxjs';
import { ApiReturn, Results } from './../../models/api-return';
import { ApiService } from './../../service/api.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {

  public pkmnList = new Observable<ApiReturn>();
  public resultsList$ = new Subject<Results[] | undefined>();

  constructor (public service: ApiService){}

  ngOnInit(): void {
     this.pkmnList = this.service.getPokemonList();
     this.pkmnList.subscribe(
      (resp) => {
        console.log(resp);
        this.resultsList$.next(resp.results);
      }
     )
  }
}
