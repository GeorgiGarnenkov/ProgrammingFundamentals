namespace PokemonEvolution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Linq.Expressions;

    public class Pokemon
    {
        public string Name { get; set; }

        public string Evolution { get; set; }

        public long Power { get; set; }
    }

    public class PokemonEvolution
    {
        public static void Main()
        {
            var line = Console.ReadLine();

            var pokemons = new List<Pokemon>();

            var isTrue = true;
            while (isTrue)
            {
                var commandArgs = line
                    .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (commandArgs.Length == 3)
                {
                    var name = commandArgs[0];
                    var evolution = commandArgs[1];
                    var power = long.Parse(commandArgs[2]);

                    var pokemon = new Pokemon();
                    pokemon.Name = name;
                    pokemon.Evolution = evolution;
                    pokemon.Power = power;

                    pokemons.Add(pokemon);
                }

                if (commandArgs.Length == 1)
                {
                    var currentName = commandArgs[0];
                    var currentPokemon = pokemons.Where(p => p.Name == currentName).FirstOrDefault();

                    if (currentPokemon != null)
                    {
                        Console.WriteLine($"# {currentName}");

                        foreach (var pokemon in pokemons.Where(p => p.Name == currentName))
                            Console.WriteLine($"{pokemon.Evolution} <-> {pokemon.Power}");
                    }
                }
                if (line == "wubbalubbadubdub")
                {
                    foreach (var namee in pokemons
                        .Select(p => p.Name)
                        .Distinct()
                        .ToList())
                    {
                        Console.WriteLine($"# {namee}");
                        foreach (var evolutionn in pokemons
                            .Where(p => p.Name == namee)
                            .OrderByDescending(p => p.Power))
                            Console.WriteLine($"{evolutionn.Evolution} <-> {evolutionn.Power}");
                    }
                    isTrue = false;
                }

                line = Console.ReadLine();
            }
        }
    }
}
