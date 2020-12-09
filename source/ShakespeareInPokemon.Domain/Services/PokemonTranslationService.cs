using System;
using System.Threading;
using System.Threading.Tasks;
using ShakespeareInPokemon.Data.Interfaces.Services;
using ShakespeareInPokemon.Domain.Interfaces.Domain;
using ShakespeareInPokemon.Domain.Interfaces.Models;
using ShakespeareInPokemon.Domain.Interfaces.Services;
using ShakespeareInPokemon.Domain.Models;

namespace ShakespeareInPokemon.Domain.Services
{
    public class PokemonTranslationService : IPokemonTranslationService
    {
        #region members

        private readonly IPokemonApiService _pokemonApiService;
        private readonly IShakespeareTranslationService _shakespeareTranslationService;

        #endregion  // members


        #region public methods

        public PokemonTranslationService(
            IPokemonApiService pokemonApiService,
            IShakespeareTranslationService shakespeareTranslationService)
        {
            _pokemonApiService = pokemonApiService ?? throw new ArgumentNullException(nameof(pokemonApiService));
            _shakespeareTranslationService = shakespeareTranslationService ?? throw new ArgumentNullException(nameof(shakespeareTranslationService));
        }

        public async Task<IPokemonModel> Translate(
            string pokemonName,
            CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(pokemonName))
            {
                throw new ArgumentNullException("Value cannot be null or whitespace.", nameof(pokemonName));
            }

            IPokemon pokemon = await _pokemonApiService.GetByName(pokemonName, cancellationToken)
                .ConfigureAwait(false);

            if (pokemon is null)
            {
                return default;
            }

            string translation = await _shakespeareTranslationService.GetTranslation(pokemon.OriginalDescription, cancellationToken)
                .ConfigureAwait(false);

            return new PokemonModel
            {
                Name = pokemon.Name,
                Description = translation
            };
        }

        #endregion  // public methods
    }
}