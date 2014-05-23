namespace SpecCourse_Lab2WithAuth.Migrations
{
    using SpecCourse_Lab2WithAuth.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SpecCourse_Lab2WithAuth.Models.LibraryDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SpecCourse_Lab2WithAuth.Models.LibraryDbContext context)
        {
            // We can set here some initial data

            //Authors
            Author Kipling = new Author
            {
                Name = "Redyard Kipling",
                BirthDate = DateTime.Parse("01-01-1953"),
                Books = new List<Book>()
            };

            Author Lukyanenko = new Author
            {
                Name = "Sergey Lukuyanenko",
                BirthDate = DateTime.Parse("01-01-1943"),
                Books = new List<Book>()
            };

            Author Vasiliev = new Author
            {
                Name = "Boris Vasiliev",
                BirthDate = DateTime.Parse("01-01-1953"),
                Books = new List<Book>()
            };

            Author King = new Author
            {
                Name = "Stephen King",
                BirthDate = DateTime.Parse("21-09-1953"),
                Books = new List<Book>()
            };

            Author Po = new Author
            {
                Name = "Edgar Allan Po",
                BirthDate = DateTime.Parse("21-09-1873"),
                Books = new List<Book>()
            };


            //Books
            Book Rikitikitavi = new Book
            {
                Title = "Riki-tiki-tavi",
                PublishingDate = DateTime.Parse("01-01-1973"),
                Authors = new List<Author>
                {
                    Kipling
                }
            };


            Book NightWatch = new Book
            {
                Title = "Night Watch",
                PublishingDate = DateTime.Parse("01-01-1973"),
                Authors = new List<Author> { 
                    Lukyanenko
                }
            };

            Book DayWatch = new Book
            {
                Title = "Day Watch",
                PublishingDate = DateTime.Parse("01-01-1973"),
                Authors = new List<Author> { 
                    Lukyanenko,
                    Vasiliev
                }
            };

            Book DarkTower1 = new Book
            {
                Title = "Dark Tower I, The",
                PublishingDate = DateTime.Parse("01-01-1973"),
                Authors = new List<Author> { 
                    King
                }
            };

            Book DarkTower2 = new Book
            {
                Title = "Dark Tower II, The",
                PublishingDate = DateTime.Parse("01-01-1983"),
                Authors = new List<Author> { 
                    King
                }
            };

            Book DarkTower3 = new Book
            {
                Title = "Dark Tower III, The",
                PublishingDate = DateTime.Parse("01-01-1993"),
                Authors = new List<Author> { 
                    King
                }
            };

            Book DarkTower4 = new Book
            {
                Title = "Dark Tower IV, The",
                PublishingDate = DateTime.Parse("01-01-1997"),
                Authors = new List<Author> { 
                    King
                }
            };

            Book DarkTower5 = new Book
            {
                Title = "Dark Tower V, The",
                PublishingDate = DateTime.Parse("01-01-2001"),
                Authors = new List<Author> { 
                    King
                }
            };

            Book DarkTower6 = new Book
            {
                Title = "Dark Tower VI, The",
                PublishingDate = DateTime.Parse("01-01-2003"),
                Authors = new List<Author> { 
                    King
                }
            };

            Book DarkTower7 = new Book
            {
                Title = "Dark Tower VII, The",
                PublishingDate = DateTime.Parse("01-01-2005"),
                Authors = new List<Author> { 
                    King
                }
            };

            Book LastJoke = new Book
            {
                Title = "Last Joke, The",
                PublishingDate = DateTime.Parse("01-01-1900"),
                Authors = new List<Author> { 
                    Po
                }
            };


            Kipling.Books.Add(Rikitikitavi);

            Vasiliev.Books.Add(DayWatch);
            Lukyanenko.Books.Add(NightWatch);
            Lukyanenko.Books.Add(DayWatch);

            King.Books.Add(DarkTower1);
            King.Books.Add(DarkTower2);
            King.Books.Add(DarkTower3);
            King.Books.Add(DarkTower4);
            King.Books.Add(DarkTower5);
            King.Books.Add(DarkTower6);
            King.Books.Add(DarkTower7);

            Po.Books.Add(LastJoke);

            context.Authors.AddOrUpdate(r => r.Name,
                                Kipling,
                                Lukyanenko,
                                Vasiliev,
                                King,
                                Po);
        }
    }
}
