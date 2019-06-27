using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Trainer
{
    public class Trainer
    {
        public string  Name { get; set; }

        public int NumberOfBadges { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public Trainer()
        {
            this.Pokemons = new List<Pokemon>();
        }

        public Trainer(String name): this()
        {
            this.Name = name;
        }

        public Trainer (string name,  Pokemon pokemon): this()
        {
            this.Name = name;
            this.Pokemons.Add(pokemon);
        }

    } 
}
