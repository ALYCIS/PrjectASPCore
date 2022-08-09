using Microsoft.AspNetCore.Mvc;
using PrjectASPCore.Repository.Books;
using PrjectASPCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjectASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepository;
        public HomeController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public IActionResult Index()
        {
            var listBook = new BookListViewModel();
            listBook.Books = _bookRepository.GetAllBooks().Take(4); // normalement il faut définir une fonction dans l'interface
            return View(listBook);
        }
    }
}
