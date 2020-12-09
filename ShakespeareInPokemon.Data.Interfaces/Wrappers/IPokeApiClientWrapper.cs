using System.Threading;
using System.Threading.Tasks;
using PokeApiNet;

namespace ShakespeareInPokemon.Data.Interfaces.Wrappers
{
    public interface IPokeApiClientWrapper
    {
        #region methods

        Task<TNamedApiResource> GetResourceAsync<TNamedApiResource>(
            string pokemonName,
            CancellationToken cancellationToken)
            where TNamedApiResource : NamedApiResource;

        #endregion  // methods
    }
}