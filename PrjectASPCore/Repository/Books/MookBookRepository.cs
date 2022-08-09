using PrjectASPCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjectASPCore.Repository.Books
{
    public class MookBookRepository : IBookRepository
    {
        public IEnumerable<Models.Book> AllBooks { get; protected set; } // Read Only
        protected ICategoryBookRepository _category = new MookCategoryBookRepository(); // Recup toutes les cathégories

        public MookBookRepository() // Constructeur
        {
            string Ldesc = "Douglas Crockford est un programmeur et entrepreneur americain, notamment connu pour sa forte implication dans le developpement du langage JavaScript et pour la creation du format JSON";
            string img = "https://images-na.ssl-images-amazon.com/images/I/41AT0uk0NjL._SX402_BO1,204,203,200_.jpg";
            string Ldesc1 = "Ce livre s’adresse à tous les développeurs web, qu’ils soient débutants ou avancés.Le JavaScript sert avant tout à rendre les pages web interactives et dynamiques du côté de l’utilisateur, mais il est également de plus en plus souvent utilisé côté serveur.La première partie de ce livre explique les bases et les bonnes pratiques de la programmation en JavaScript en se fondant sur la version ECMAScript 6.La deuxième partie porte sur l’interactivité avec les utilisateurs(interfaces, formulaires, gestion des erreurs, géolocalisation...).La troisième partie permet de s’initier aux aspects les plus avancés de JavaScript tels que Node.js, React ou les Web Workers.Les renvois de type tjs.ovh / nomScript qui sont présents au fil des pages sont des compléments interactifs à ce livre";
            string img1 = "https://static.fnac-static.com/multimedia/Images/FR/NR/6e/86/c2/12748398/1540-1/tsp20201008221031/Tout-JavaScript.jpg";
            string Ldesc2 = "The design and use of multi-standard RF transceivers is the way to increase hardware flexibility and functionality, as well as to improve the flexibility of set-makers on the market. In the design of multi-standard RF transceivers the efforts will be directed towards improvement of hardware reusability, reconfigurability, programmability and flexibility. This will result in the launching of a software-defined radio";
            string img2 = "https://media.springernature.com/w92/springer-static/cover/book/978-1-4020-6534-7.jpg?as=webp";
            string Ldesc3 = "Les Nouvelles Technologies de l'Information et de la Communication (NTIC) sont intégrées à nos activités quotidiennes. En particulier, la prolifération des médias sociaux favorise une culture du bavardage, et une obsession à l'audienciation de soi. De sorte que, l'individu produit de plus en plus de données personnelles, intimes, sociales, ou sensibles. Dans ce contexte, les dispositifs de traitement de données \" big data \" présentent des enjeux importants pour le citoyen. Car en utilisant nos données intimes, ces technologies, dites \" nouvelles \", s'exposent aux difficultés associées à leurs utilisations : le respect de la vie privée et des libertés fondamentales de \" l'Homo numericus \" ";
            string img3 = "https://coverart.oclc.org/ImageWebSvc/oclc/+-+7414784076_140.jpg?SearchOrder=+-+OT,OS,TN,GO,FA";
            string Ldesc4 = "Le Big Data (ou mégadonnées) suscite des discours porteurs de visions économiques prometteuses: efficience du microciblage, meilleurs rendements par gestion prédictive, algorithmes et intelligence artificielle, villes intelligentes... bref, toute une économie des données qui trouverait son achèvement véritable dans une créativité enfin libérée de tout joug disciplinaire, idéologique et politique. L’éclatement des individualités «émancipées» sonde le «social» tel qu’il est porté par ces discours de promotion. En effet, force est de constater que le social est relativement absent, pour l’instant, des réflexions que l’on présente comme névralgiques pour un avenir meilleur.";
            string img4 = "https://books.google.com/books/publisher/content/images/frontcover/2MoqEAAAQBAJ?fife=w240-h480";
            string Ldesc5 = "Qu’est-ce que le big data ? Le big data est constitué par toutes les données que nous générons à chaque instant, dont le volume global croît exponentiellement. De l’historique de navigation aux localisations GPS, jusqu’au rythme cardiaque, à la météo et au solde des comptes courants, ces données récoltées par les mobiles, applications et autres objets connectés génèrent de nouveaux usages pour les États et les entreprises.Le big data, pour quoi faire? Les entreprises doivent apprendre à maîtriser ces flux d’information, pour réinventer leurs relations avec le consom’acteur, leurs produits et services ainsi que leurs organisations. Aujourd’hui, comme demain, la donnée, c’est de l’argent.";
            string img5 = "https://books.google.com/books/publisher/content/images/frontcover/rFOQBAAAQBAJ?fife=w240-h480";
            string Ldesc6 = "This volume contains the proceedings of the Fifth International Conference on Database Systems for Advanced Applications (DASFAA '97). DASFAA '97 focused on advanced database technologies and their applications. The 55 papers in this volume cover a wide range of areas in the field of database systems and applications - including the rapidly emerging areas of the Internet, multimedia, and document database systems - and should be of great interest to all database system researchers and developers, and practitioners.";
            string img6 = "https://m.media-amazon.com/images/I/41htRM-mvtL._AC_UY327_FMwebp_QL65_.jpg";
            string Ldesc7 = "Need to master database programming in C#? Database Programming with C# is your ultimate resource! You will learn to create database details like tables, constraints, projects, stored procedures, views, triggers, and more. You will build on example code from the books beginning, wrapping up in the final chapter. (The example application is a complete user management system that includes SQL Server, Active Directory, and Message Queuing.)";
            string img7 = "https://coverart.oclc.org/ImageWebSvc/oclc/+-+7207754756_140.jpg?SearchOrder=+-+OT,OS,TN,GO,FA";
            string Ldesc8 = "Cet ouvrage explique comment mettre en place un back-end pour votre application mobile, grâce au framework Django. Vous apprendrez à créer un backoffice, une api REST (sécurisée grâce à oAuth2), à envoyer des pushs, à uploader des photos, mais aussi à effectuer des traitements automatiques sous forme de batchs. ";
            string img8 = "https://books.google.com/books/publisher/content/images/frontcover/TnilDQAAQBAJ?fife=w240-h480";

            AllBooks = new List<Book>
            {
                //(int id, string name, string description, string type,string Ldesc, decimal price, bool instock, string urlImg)
                new Book(1,"JavaScript: Gardez le meilleur !","Livre de JavaScript","Livre",Ldesc,8.92m,true,img,"2008","9782744023286",_category.GetCategoryBookById(3),3,DateTime.Now.ToString()),
                new Book(2,"Tout JavaScript","Livre de JavaScript","Livre",Ldesc1,22.99m,true,img1,"2019","9782100818969",_category.GetCategoryBookById(3),3,DateTime.Now.ToString()),
                new Book(3,"Adaptive Multi-Standard RF Front-Ends","Livre Front-end","Livre",Ldesc2,117.69m,true,img2,"2008","9781402065347",_category.GetCategoryBookById(3),3,DateTime.Now.ToString()),
                new Book(4,"Big data à l'âge Petabyte","Livre sur le Big data","Livre",Ldesc3,21.98m,true,img3,"15 juin 2021","9782322251568",_category.GetCategoryBookById(1),1,DateTime.Now.ToString()),
                new Book(5,"Big Data et société","Industrialisation des médiations symboliques","Livre",Ldesc4,21.99m,true,img4,"19 septembre 2018","9782760550193",_category.GetCategoryBookById(1),1,DateTime.Now.ToString()),
                new Book(6,"La Révolution Big data","Les données au coeur de la transformation de l'entreprise","Livre",Ldesc5,16.99m,true,img5,"24 septembre 2014","9782100718917",_category.GetCategoryBookById(1),1,DateTime.Now.ToString()),
                new Book(7,"Database Systems for Advanced Applications '97","Proceedings of the Fifth International Conference on Database Systems for Advanced Applications, Melbourne, April 1-4, 1997","Livre",Ldesc6,16.99m,true,img6,"1997","9789810231071",_category.GetCategoryBookById(2),2,DateTime.Now.ToString()),
                new Book(8,"Livre de Database","Proceedings of the Fifth International Conference on Database Systems for Advanced Applications, Melbourne, April 1-4, 1997","Livre",Ldesc7,47.46m,true,img7,"5 avril 2002","9781430210986",_category.GetCategoryBookById(2),2,DateTime.Now.ToString()),
                new Book(9,"Livre de Database","Proceedings of the Fifth International Conference on Database Systems for Advanced Applications, Melbourne, April 1-4, 1997","Livre",Ldesc7,47.46m,true,img7,"5 avril 2002","9781430210986",_category.GetCategoryBookById(4),4,DateTime.Now.ToString()),
                new Book(10,"Développez un back-end pour app mobile avec Django","Livre Back-End","Livre",Ldesc8,14.99m,true,img8,"5 décembre 2016","9782955946602",_category.GetCategoryBookById(4),4,DateTime.Now.ToString())
            };
        }
        public IEnumerable<Book> GetAllBooks()
        {
            return AllBooks;
        }
         
        public Models.Book GetBookById(int id)
        {
            return AllBooks.FirstOrDefault(b => b.Id == id);
        }
    }
}
