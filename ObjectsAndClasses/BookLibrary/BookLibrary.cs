using System.Security.Policy;

namespace BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;


    public class Library
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }

    }

    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime Date { get; set; }

        public string Isbn { get; set; }

        public decimal Price { get; set; }

    }

    public class AuthorInfo
    {
        public string Author { get; set; }

        public decimal Sales { get; set; }
    }

    public class BookLibrary
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            Library library = new Library()
            {
                Name = "Sofia",
                Books = new List<Book>()
            };

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                var title = tokens[0];
                var author = tokens[1];
                var publisher = tokens[2];
                var date = DateTime.ParseExact(tokens[3], "dd.MM.yyyy",
                    CultureInfo.InvariantCulture);
                var isbn = tokens[4];
                var price = decimal.Parse(tokens[5]);

                var book = new Book()
                {
                    Title = title,
                    Author = author,
                    Publisher = publisher,
                    Date = date,
                    Isbn = isbn,
                    Price = price
                };

                library.Books.Add(book);
            }

            var authorSales = library.Books
                .Select(a => a.Author)
                .Distinct()
                .Select(author => new AuthorInfo()
                {
                    Author = author,
                    Sales = library.Books.Where(book => book.Author == author).Sum(b => b.Price)
                })
                .OrderByDescending(authorInfo => authorInfo.Sales)
                .ThenBy(a => a.Author)
                .ToArray();

            foreach (var authorInfo in authorSales)
            {
                Console.WriteLine($"{authorInfo.Author} -> {authorInfo.Sales:f2}");
            }
        }
    }
}
