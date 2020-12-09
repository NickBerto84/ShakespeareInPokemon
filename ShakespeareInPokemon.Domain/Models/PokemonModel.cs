using System;
using System.Collections.Generic;
using System.Text;
using ShakespeareInPokemon.Domain.Interfaces.Models;

namespace ShakespeareInPokemon.Domain.Models
{
    public class PokemonModel : IPokemonModel
    {
        #region properties

        public string Name { get; set; }

        public string Description { get; set; }

        #endregion  // properties
    }
}
