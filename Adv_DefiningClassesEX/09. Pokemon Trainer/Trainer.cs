using System;
using System.Collections.Generic;

namespace PokemonTrainer
{
    public class Trainer
    {
        public string Name { get; set; }
        public int NumberBadges { get; set; }

        private List<Pokemon> pokemons = new List<Pokemon>();
        public List<Pokemon> Pokemons { get => pokemons; set => pokemons = value; }
    }
}
