namespace HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsOfCards
    {
        public static void Main()
        {
            var cardPowers = GetCardPowers();
            var cardTypes = GetCardTypes();

            Dictionary<string, HashSet<int>> cards = new Dictionary<string, HashSet<int>>();

            var line = Console.ReadLine();

            while (line != "JOKER")
            {
                var command = line.Split(':');

                var name = command[0];
                var playerCards = command[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in playerCards)
                {
                    var cardPower = card.Substring(0, card.Length - 1);
                    var cardType = card.Substring(card.Length - 1);

                    var sum = cardPowers[cardPower] * cardTypes[cardType];
                    if (!cards.ContainsKey(name))
                    {
                        cards[name] = new HashSet<int>();
                    }
                    cards[name].Add(sum);
                }
                line = Console.ReadLine();
            }

            foreach (var pair in cards)
            {
                var name = pair.Key;
                var cardsSum = pair.Value.Sum();

                Console.WriteLine($"{name}: {cardsSum}");
            }
        }

        private static Dictionary<string, int> GetCardTypes()
        {
            var powersOfTypes = new Dictionary<string, int>();

            powersOfTypes["S"] = 4;
            powersOfTypes["H"] = 3;
            powersOfTypes["D"] = 2;
            powersOfTypes["C"] = 1;

            return powersOfTypes;
        }

        private static Dictionary<string, int> GetCardPowers()
        {
            var powers = new Dictionary<string, int>();

            for (int i = 2; i <= 10; i++)
            {
                powers[i.ToString()] = i;
            }

            powers["J"] = 11;
            powers["Q"] = 12;
            powers["K"] = 13;
            powers["A"] = 14;

            return powers;
        }
    }
}
