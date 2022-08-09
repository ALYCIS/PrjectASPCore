using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjectASPCore.Repository.Books
{
    public interface IBookRepository
    {
        public IEnumerable<Models.Book> GetAllBooks();
        public Models.Book GetBookById(int id);
    }
}
