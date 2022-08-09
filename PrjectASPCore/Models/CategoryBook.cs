using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrjectASPCore.Models
{
    public class CategoryBook
    {
        [Key]
        public int CategoryId { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string type { get; protected set; }
        public List<Book> Books { get; protected set; }
        public CategoryBook() : base() // constructeur par default
        {
            Books = new List<Book>();
        }
        /* public Category(ModelArticle M) : base(M.Id, M.Name, M.Description) { } // Un autre constructeur qui prend un modèle d'article*/
        public CategoryBook(int id, string name, string description, string type = "Livre")
        {
            CategoryId = id;
            this.Name = name;
            this.Description = description;
            this.type = type;
        }

        public override string ToString()
        {
            return "category: " + Name + " id=" + CategoryId + " | CatDescription:" + Description;
        }


    }
}