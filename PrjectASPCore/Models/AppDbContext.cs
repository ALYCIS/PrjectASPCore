using PrjectASPCore.Repository.Books;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjectASPCore.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; protected set; }
        public DbSet<CategoryBook> CategoryBooks { get; protected set; }

        // Pour initialiser, il faut override, faire une migration à chaque modif de appContext
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            MookCategoryBookRepository MCBook = new MookCategoryBookRepository();

            foreach (var cb in MCBook.AllCategoryBooks)
            {
                modelBuilder.Entity<CategoryBook>().HasData(
                    cb
                );
            }
            // Pour les livres

            MookBookRepository MBook = new MookBookRepository();
            foreach (var b in MBook.AllBooks)
            {
                modelBuilder.Entity<Book>().HasData(
                  b
                 );
            }

        }
    }
}
