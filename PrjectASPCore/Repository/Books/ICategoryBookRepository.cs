using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjectASPCore.Repository.Books
{
    public interface ICategoryBookRepository
    {
        public IEnumerable<Models.CategoryBook> GetAllCategoryBooks();
        public Models.CategoryBook GetCategoryBookById(int id);
    }
}
