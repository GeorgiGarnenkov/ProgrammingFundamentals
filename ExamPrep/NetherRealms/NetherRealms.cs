namespace NetherRealms
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    
    public class NetherRealms
    {
        static void Main()
        {
            var demons = Console.ReadLine()
                .Split(new [] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(d => d)
                .ToArray();

            foreach (string demon in demons)
            {
                double demonHealth = GetHealth(demon);
                decimal demonDamage = GetDamage(demon);
                Console.WriteLine($"{demon} - {demonHealth} health, {demonDamage:F2} damage");
            }
        }

        private static decimal GetDamage(string demon)
        {
            string damagePattern = @"[\-\+]?[\d]+(?:[\.]*[\d]+|[\d]*)";

            MatchCollection collection = Regex.Matches(demon, damagePattern);

            decimal damage = 0;
            foreach (var number in collection)
            {
                damage += decimal.Parse(number.ToString());
            }

            foreach (char c in demon.Where(c => c == '*' || c == '/'))
            {
                if (c == '*')
                {
                    damage *= 2;
                }
                else
                {
                    damage /= 2;
                }
            }

            return damage;
        }

        private static double GetHealth(string demon)
        {
            string healthPattern = @"[^\d\.\+\-\*\/\s\,]";

            MatchCollection collection = Regex.Matches(demon, healthPattern);

            double health = 0;
            foreach (Match str in collection)
            {
                foreach (char c in str.ToString())
                {
                    health += c;
                }
            }

            return health;
        }
    }
}
