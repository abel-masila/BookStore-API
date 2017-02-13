namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BookStore.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BookStore.Models.BookStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookStore.Models.BookStoreContext context)
        {
            context.Authors.AddOrUpdate(x=> x.Id,
                new Author() { Id=1,Name="Abel Masila"},
                new Author() { Id = 2, Name = "Charles Dickens" },
                new Author() { Id = 3, Name = "Miguel de Cervantes" }
                );
            context.Books.AddOrUpdate(x => x.Id,
                new Book() { Id = 1, Title = "Pride and Prejudice", Year = 2013, AuthorId = 1, Price = 1200.50M, Genre = "Comedy of manners" },
                new Book() { Id = 2, Title = "Northanger Abbey", Year = 1817, AuthorId = 1, Price = 12.95M, Genre = "Gothic parody" },
                new Book() { Id = 4, Title = "Don Quixote", Year = 1617, AuthorId = 3, Price = 8.95M, Genre = "Picaresque" }
                );
        }
    }
}
