namespace ShakespeareInPokemon.Domain.Interfaces.Domain
{
    public interface IPokemon
    {
        #region properties

        string Name { get; set; }

        string OriginalDescription { get; set; }

        string Translation { get; set; }

        #endregion  // properties
    }
}