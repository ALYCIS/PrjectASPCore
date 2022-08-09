using PrjectASPCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjectASPCore.Repository.Books
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _appDbContext;
        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Book> GetAllBooks()
        {
            return _appDbContext.Books.Include(c => c.CategoryBook);
        }

        public Book GetBookById(int id)
        {
            return _appDbContext.Books.FirstOrDefault(b => b.Id == id);
        }
    }
}
