using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryDataAccess.Interfaces;
using LibraryDataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }


        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_bookRepository.GetAllBooks());
        }

        [HttpPost]
        public ActionResult Add(Book book)
        {
            _bookRepository.AddBook(book);
            return Ok("created");
        }

        [HttpPut("{id}")]
        public ActionResult Edit(int id, Book book)
        {
            _bookRepository.EditBook(id, book);
            return Ok();
        }
    }
}