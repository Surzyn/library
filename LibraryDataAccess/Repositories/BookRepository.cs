using LibraryDataAccess.Interfaces;
using LibraryDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryDataAccess.Repositories
{
    public class BookRepository : IBookRepository
    {
        public List<Book> GetAllBooks()
        {
            using (var dbContext = new LibraryContext())
            {
                return dbContext.Books.ToList();
            }
        }

        public void AddBook(Book newBook)
        {
            using(var dbContext = new LibraryContext())
            {
                dbContext.Books.Add(newBook);
                dbContext.SaveChanges();
            }
        }

        public void EditBook(int id, Book book)
        {
            using (var db = new LibraryContext())
            {
                var existBook = db.Books.Single(x => x.Id == id);
                existBook.Title = book.Title;
                existBook.Author = book.Author;
                db.SaveChanges();
            }
        }
    }
}
