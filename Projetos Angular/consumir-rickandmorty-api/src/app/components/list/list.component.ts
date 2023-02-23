import { Component } from '@angular/core';
import { Subject } from 'rxjs';
import { Results } from 'src/app/models/api-return';
import { ApiService } from 'src/app/service/api.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent {
  public resultsList$ = new Subject<Results[] | undefined>();

  constructor(public service: ApiService) { }

  ngOnInit(): void {
    this.service.getCharacterList().subscribe(
      (resp) => {
        console.log(resp);
        this.resultsList$.next(resp.results);
      }
    );
    }
}
