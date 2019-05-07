using System.Xml;

namespace BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
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
        public string Title { get; set; }

        public DateTime Date { get; set; }
    }


    public class BookLibraryModification
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            bool end = true;

            while (end)
            {
                Library library = new Library()
                {
                    Name = "Sofia",
                    Books = new List<Book>()
                };

                for (int i = 0; i < int.Parse(input); i++)
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

                DateTime endLineDate = DateTime
                    .ParseExact(Console.ReadLine(), "dd.MM.yyyy",
                        CultureInfo.InvariantCulture);

                var titleAndDate = library.Books
                    .Distinct()
                    .OrderBy(d => d.Date)
                    .ThenBy(a => a.Title)
                    .ToArray();
                
                foreach (var authorInfo in titleAndDate)
                {
                    if (authorInfo.Date > endLineDate)
                    {
                        Console.WriteLine($"{authorInfo.Title} -> {authorInfo.Date.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture)}");
                    }
                }

                end = false;
            }
        }
    }
}
