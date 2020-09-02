using LibraryDataAccess.Interfaces;
using LibraryDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDataAccess.Repositories
{
    public class MockBookRepository : IBookRepository
    {
        public List<Book> GetAllBooks()
        {
            return new List<Book>()
           {
               new Book(){Id=1, Title="Brave new world", Author = "Bleble"},
               new Book(){Id=2, Title="Mieso i przyjaciele", Author="Bartek"}
           };
        }
    }
}
