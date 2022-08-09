using PrjectASPCore.Models;
using PrjectASPCore.Repository.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjectASPCore.Repository.Books
{
    public class CategoryBookRepository : ICategoryBookRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryBookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<CategoryBook> GetAllCategoryBooks()
        {
            return _appDbContext.CategoryBooks;
        }

        public CategoryBook GetCategoryBookById(int id)
        {
            return _appDbContext.CategoryBooks.FirstOrDefault(c => c.CategoryId == id);
        }
    }
}
