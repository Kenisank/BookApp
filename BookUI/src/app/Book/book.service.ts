import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Book } from './book';
import { Observable, tap } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class BookService {

  private apiUrl = 'http://localhost:5155';


  constructor(private http: HttpClient) { }

  getBooks(): Observable<Book[]> {
    return this.http.get<Book[]>(this.apiUrl).pipe(
      tap((books: any) => console.log('Fetched books:', books)));

  }
 


}
