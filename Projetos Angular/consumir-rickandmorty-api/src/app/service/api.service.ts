import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ApiReturn } from './../models/api-return';
import { Character } from '../models/character-model';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  URL_API:string = "https://rickandmortyapi.com/api/character"

  constructor(public http:HttpClient) {}

  getCharacterList () {
    return this.http.get<ApiReturn>(this.URL_API);
  }

  getCharacterById (id: number) {
    return this.http.get<Character>(`${this.URL_API}/${id}`);
  }
}
