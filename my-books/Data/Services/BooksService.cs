using my_books.Data.Models;
using my_books.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace my_books.Data.Services
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }
        //passing view model to maintain abstraction: e.g id, date added are not provided by the user
        public void AddBook(BookVM book)
        {
            var _book = new Book()
            {
                Title = book.Title,
                Description = book.Description,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Rate = book.Rate,
                Genre = book.Genre,
                Author = book.Author,
                CoverUrl = book.CoverUrl,
                DateAdded = DateTime.Now
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }

        //It will return all the books from the DB
        public List<Book> GetAllBooks() => _context.Books.ToList();

        //Get single book
        //FirstOrDefault checks whether the book is present or not, and if not present then it will return a default value instead of an exception
        public Book GetBookById(int bookId) => _context.Books.FirstOrDefault(n => n.Id == bookId);

        //Update book data in DB
        //BookVM is added as param to maintain abstraction while updating (like before!)
        public Book UpdateBookById(int bookId, BookVM book)
        {
            var _book = _context.Books.FirstOrDefault(n => n.Id == bookId);
            if(_book != null) 
            {
                _book.Title = book.Title;
                _book.Description = book.Description;
                _book.IsRead = book.IsRead;
                _book.DateRead = book.DateRead;
                _book.Rate = book.Rate;
                _book.Genre = book.Genre;
                _book.Author = book.Author;
                _book.CoverUrl = book.CoverUrl;

                _context.SaveChanges();
            }
            return _book;
        }

        //Delete a book
        public void DeleteBookById(int bookId)
        {
            var _book = _context.Books.FirstOrDefault(n => n.Id == bookId);
            if (_book != null)
            {
                _context.Books.Remove(_book);
                _context.SaveChanges();
            }
        }
    }
}
