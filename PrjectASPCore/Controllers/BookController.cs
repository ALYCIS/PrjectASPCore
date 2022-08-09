using PrjectASPCore.Repository.Books;
using PrjectASPCore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjectASPCore.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ICategoryBookRepository _categoryBookRepository;

        public BookController(IBookRepository bookRepository, ICategoryBookRepository categoryBookRepository)
        {
            _bookRepository = bookRepository;
            _categoryBookRepository = categoryBookRepository;
        }
        public IActionResult ListBooks()
        {
            var bookListViewModel = new BookListViewModel();
            bookListViewModel.Books = _bookRepository.GetAllBooks();
            return View(bookListViewModel);
        }
    }
}
