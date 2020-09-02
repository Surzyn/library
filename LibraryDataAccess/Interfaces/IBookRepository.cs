using LibraryDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDataAccess.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        void AddBook(Book newBook);

        void EditBook(int id, Book book);
    }
}
