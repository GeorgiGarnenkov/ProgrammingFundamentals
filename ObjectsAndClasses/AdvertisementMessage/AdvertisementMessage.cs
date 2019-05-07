namespace AdvertisementMessage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AdvertisementMessage
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrases =
            {
                "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events =
            {
                "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"
            };

            string[] authors =
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            string[] towns =
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            var rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int phraseIndex = rnd.Next(0, phrases.Length);
                int eventIndex = rnd.Next(0, events.Length);
                int authorIndex = rnd.Next(0, authors.Length);
                int townIndex = rnd.Next(0, towns.Length);
                Console.WriteLine($"{phrases[phraseIndex]} {events[eventIndex]} {authors[authorIndex]}" +
                                  $" – {towns[townIndex]}");
            }
        }
    }
}
