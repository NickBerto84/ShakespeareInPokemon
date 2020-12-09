using ShakespeareInPokemon.Domain.Interfaces.Domain;

namespace ShakespeareInPokemon.Domain
{
    public class Pokemon : IPokemon
    {
        #region properties

        public string Name { get; set; }

        public string OriginalDescription { get; set; }

        public string Translation { get; set; }

        #endregion  // properties
    }
}
