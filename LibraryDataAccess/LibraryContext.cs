using LibraryDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDataAccess
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-5KOF6PB\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
        }
    }
}
