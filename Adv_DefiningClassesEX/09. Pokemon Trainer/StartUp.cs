using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new();

            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] tokens = input.Split();
                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer());
                }
                trainers[trainerName].Name = trainerName;
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                trainers[trainerName].Pokemons.Add(pokemon);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    Pokemon existsQ = trainer.Value.Pokemons.Find(x => x.Element == command);
                    if (existsQ == null)
                    {
                        trainer.Value.Pokemons.ForEach(x => x.Health -= 10);
                        trainer.Value.Pokemons.RemoveAll(x => x.Health <= 0);
                    }
                    else
                    {
                        trainer.Value.NumberBadges++;
                    }
                }
            }

            List<Trainer> endTrainers = trainers.Values.ToList();
            endTrainers = endTrainers.OrderByDescending(x => x.NumberBadges).ToList();
            foreach (var trainer in endTrainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
