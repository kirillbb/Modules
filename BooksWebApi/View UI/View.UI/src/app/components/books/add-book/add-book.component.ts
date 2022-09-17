import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Book } from 'src/app/models/book.model';
import { BooksService } from 'src/app/services/books.service';

@Component({
  selector: 'app-add-book',
  templateUrl: './add-book.component.html',
  styleUrls: ['./add-book.component.css']
})
export class AddBookComponent implements OnInit {

  addBookRequest: Book ={
    id: '',
    title: '',
    author: ''
  }
  constructor(private booksService: BooksService, private router: Router) { }

  ngOnInit(): void {
  }

  addBook() {
    this.booksService.addBook(this.addBookRequest)
    .subscribe({
      next: (book) => {
        this.router.navigate(['books']);
      },
      error: (response) => {
        console.log(response);
      }
    });
  }
}
