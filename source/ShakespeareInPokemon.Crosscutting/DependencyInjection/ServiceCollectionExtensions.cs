using Microsoft.Extensions.DependencyInjection;
using ShakespeareInPokemon.Data.Interfaces.Services;
using ShakespeareInPokemon.Data.Interfaces.Wrappers;
using ShakespeareInPokemon.Data.Services;
using ShakespeareInPokemon.Data.Wrappers;
using ShakespeareInPokemon.Domain.Interfaces.Services;
using ShakespeareInPokemon.Domain.Services;

namespace ShakespeareInPokemon.Crosscutting.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        #region public methods

        public static IServiceCollection ConfigureDataDependencies(this IServiceCollection services)
        {
            return services
                .AddHttpClient()
                .AddSingleton<IHttpClientWrapper, HttpClientWrapper>()
                .AddSingleton<IShakespeareTranslationService, ShakespeareTranslationService>()
                .AddSingleton<IPokeApiClientWrapper, PokeApiClientWrapper>()
                .AddSingleton<IPokemonApiService, PokemonApiService>();
        }

        public static IServiceCollection ConfigureDomainDependencies(this IServiceCollection services)
        {
            return services
                .AddSingleton<IPokemonTranslationService, PokemonTranslationService>();
        }

        #endregion  // public methods
    }
}
