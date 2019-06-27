using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Trainer                       // 100 / 100
{
    public class StartUp
    {
        public static void Main()
        {
            string input = String.Empty;

            var trainers = new Dictionary<string, Trainer>();

            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] inputInfo =input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainersName = inputInfo[0];
                string pokemonsName = inputInfo[1];
                string element = inputInfo[2];
                int pokemonsHealth = int.Parse(inputInfo[3]);

                Pokemon pokemon = new Pokemon(pokemonsName, element, pokemonsHealth);
                Trainer trainer = new Trainer(trainersName, pokemon);

                if ( ! trainers.ContainsKey(trainer.Name))
                {
                    trainers.Add(trainer.Name, trainer);
                }

                else
                {
                    trainers[trainer.Name].Pokemons.Add(pokemon);
                }

               
            }

            string elementSelecton = String.Empty;

            while ((elementSelecton = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Value.Pokemons.Any(p =>p.Element == elementSelecton))
                    {
                        trainer.Value.NumberOfBadges++;
                    }

                    else
                    {
                        trainer.Value.Pokemons.ForEach(p => p.Health -= 10);

                        foreach (var tr in trainers.Values)
                        {
                            tr.Pokemons.RemoveAll(x => x.Health <= 0);
                        }
                    }
                }

            }

            

            foreach (var trainer in trainers.OrderByDescending(t => t.Value.NumberOfBadges))
            {
                int numberOfPokemons = trainer.Value.Pokemons.Where(p => p.Health >0).Count();

                Console.WriteLine($"{trainer.Key} {trainer.Value.NumberOfBadges} {numberOfPokemons}");
            }

        }
    }
}
