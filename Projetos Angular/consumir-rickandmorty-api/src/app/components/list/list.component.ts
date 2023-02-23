import { Component } from '@angular/core';
import { Subject } from 'rxjs';
import { Results } from 'src/app/models/api-return';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent {
  public resultsList$ = new Subject<Results[] | undefined>();

}
