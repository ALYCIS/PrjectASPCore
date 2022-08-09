using Microsoft.AspNetCore.Mvc;
using PrjectASPCore.Repository.Books;
using PrjectASPCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjectASPCore.Controllers
{
    public class TestController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public TestController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult Index()
        {
            var Lists = new BookListViewModel();
            Lists.Books = _bookRepository.GetAllBooks();
            return View(Lists);
        }
    }
}
