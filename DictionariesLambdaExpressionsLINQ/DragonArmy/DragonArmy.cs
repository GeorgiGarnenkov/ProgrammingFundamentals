namespace DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class DragonArmy
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, List<int>>> dragons = 
                new Dictionary<string, Dictionary<string, List<int>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(new char[] {' '},
                    StringSplitOptions.RemoveEmptyEntries);
                Dragon dragon = new Dragon();

            }
        }
    }

    public class Dragon
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public int Dmg { get; set; }

        public int Hp { get; set; }

        public int Armor { get; set; }
    }
}
