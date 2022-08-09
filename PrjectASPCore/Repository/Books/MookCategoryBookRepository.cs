using PrjectASPCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjectASPCore.Repository.Books
{
    public class MookCategoryBookRepository : ICategoryBookRepository
    {
        public IEnumerable<CategoryBook> AllCategoryBooks { get; private set; } // Read Only

        public MookCategoryBookRepository() // Constructeur
        {
            AllCategoryBooks = new List<CategoryBook>
            {
               new CategoryBook (1,"Big data","books of big data","Livre"),
               new CategoryBook (2,"Database","books of database","Livre" ),
               new CategoryBook (3,"Front-End","books of Front-End","Livre"),
               new CategoryBook (4,"Back-End","books of Back-End","Livre")
            };
        }
        public IEnumerable<CategoryBook> GetAllCategoryBooks()
        {
            return AllCategoryBooks;
        }

        public Models.CategoryBook GetCategoryBookById(int id)
        {
            return AllCategoryBooks.FirstOrDefault(c => c.CategoryId == id);
        }
    }
}
