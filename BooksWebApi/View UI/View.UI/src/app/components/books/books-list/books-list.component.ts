import { Component, OnInit } from '@angular/core';
import { Book } from 'src/app/models/book.model';
import { BooksService } from 'src/app/services/books.service';

@Component({
  selector: 'app-books-list',
  templateUrl: './books-list.component.html',
  styleUrls: ['./books-list.component.css']
})
export class BooksListComponent implements OnInit {

  books: Book[] = [];
  page: number = 1;
  constructor(private booksService: BooksService) { }

  ngOnInit(): void {
    this.showItems(this.page);
  }

  showItems(page: number) : void {
    this.booksService.getAllBooks(page)
    .subscribe({
      next: (books) => {
        this.books = books;
      },
      error: (response) => {
        console.log(response);
      }
    });
  }

}
