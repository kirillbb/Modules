import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Book } from '../models/book.model';

@Injectable({
  providedIn: 'root'
})
export class BooksService {
  baseApiUrl: string =environment.baseApiUrl;
  constructor(private http: HttpClient) { }

  getAllBooks() : Observable<Book[]> {
    return this.http.get<Book[]>(this.baseApiUrl + '/api/books')
  }
}
