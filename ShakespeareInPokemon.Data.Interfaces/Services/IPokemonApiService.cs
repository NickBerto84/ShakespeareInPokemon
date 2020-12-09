using System.Threading;
using System.Threading.Tasks;
using ShakespeareInPokemon.Domain.Interfaces.Domain;

namespace ShakespeareInPokemon.Data.Interfaces.Services
{
    public interface IPokemonApiService
    {
        #region task

        Task<IPokemon> GetByName(string pokemonName,
                                 CancellationToken cancellationToken);

        #endregion  // task
    }
}