using System.Threading;
using System.Threading.Tasks;
using ShakespeareInPokemon.Domain.Interfaces.Domain;
using ShakespeareInPokemon.Domain.Interfaces.Models;

namespace ShakespeareInPokemon.Domain.Interfaces.Services
{
    public interface IPokemonTranslationService
    {
        #region task

        Task<IPokemonModel> Translate(
            string pokemonName,
            CancellationToken none);

        #endregion  // task
    }
}