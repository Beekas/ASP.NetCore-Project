using Bikash.BookStores.Models;
using Bikash.BookStores.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Bikash.BookStores.Controllers
{
    public class BookController : Controller
    {

        private readonly BookRepository _BookRepository = null;

        public BookController()
        {
            _BookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data = _BookRepository.GetAllBooks();
            return View(data);
        }

        public ViewResult GetBook(int id)
        {
            var data = _BookRepository.GetBookById(id);
            return View(data);
        }

        public List<Book> SearchBook(string bookname, string authorname)
        {
            return _BookRepository.SearchBook(bookname, authorname);
        }
    }
}
