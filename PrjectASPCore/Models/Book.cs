using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrjectASPCore.Models
{
    public class Book
    {
        [Key]
        public int Id { get; protected set; }
        public string DateDePublication { get; protected set; }
        public string Isbn { get; protected set; }
        public bool InStock { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; set; }
        public string LongDescription { get; protected set; }
        public string UrlImag { get; protected set; }
        public string Type { get; protected set; }
        public string DateDeMiseEnLigne { get; protected set; }
        public decimal Price { get; protected set; }

        [ForeignKey("CategoryBook")]
        public int CategoryId { get; protected set; }
        public CategoryBook CategoryBook { get; set; }
        public Book()
        {
            InStock = false;
            Name = "Article";
            Description = "Ceci est une petite description!";
            LongDescription = "Ceci est longue description!";
            UrlImag = " ";
            Type = "Article";
            DateDeMiseEnLigne = "ToDay";
            Price = 0.0m;
            Type = "Livre";
        }

        public Book(int id, string name, string description, string type, string Ldesc, decimal price, bool instock, string urlimg, string datePublication, string isbn, CategoryBook C, int CId, string dateMiseEnLigne)
        {
            Id = id;
            DateDePublication = datePublication;
            Isbn = isbn;
            CategoryId = CId;
            CategoryBook = C;
            InStock = instock;
            Name = name;
            Description = description;
            LongDescription = Ldesc;
            UrlImag = urlimg;
            Type = type;
            DateDeMiseEnLigne = dateMiseEnLigne;
            Price = price;
            //Category = GetCategoryBookById(id);
        }

        public override string ToString()
        {
            return Name + " | " + "id=" + Id + " | description :" + Description + " | publiee le " + DateDePublication + " | " + CategoryBook.ToString();
        }
    }
}
