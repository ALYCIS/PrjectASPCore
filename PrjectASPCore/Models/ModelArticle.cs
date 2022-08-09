using System.ComponentModel.DataAnnotations;

namespace PrjectASPCore.Models
{
    public class ModelArticle
    {
        public bool InStock { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; set; }
        public string LongDescription { get; protected set; }
        public string UrlImag { get; protected set; }
        public string Type { get; protected set; }
        public string DateDeMiseEnLigne { get; protected set; }
        public decimal Price { get; protected set; }
        public ModelArticle()
        {
            InStock = false;
            Name = "Article";
            Description = "Ceci est une petite description!";
            LongDescription = "Ceci est longue description!";
            UrlImag = " ";
            Type = "Article";
            DateDeMiseEnLigne = "ToDay";
            Price = 0.0m;
        }
        public ModelArticle(bool inStock = false, string name = "defalt", string description = "defalt", string longDescription = "default",
            string urlImg = "No Image", string type = "Article", string dateDeMiseEnLigne = "ToDay", decimal price = 0.0m)
        {
            InStock = inStock;
            Name = name;
            Description = description;
            LongDescription = longDescription;
            UrlImag = urlImg;
            Type = type;
            DateDeMiseEnLigne = dateDeMiseEnLigne;
            Price = price;
        }

        public ModelArticle(int id, string name, string description, string type)
        {
            Name = name;
            Description = description;
            Type = type;
        }

    }
}