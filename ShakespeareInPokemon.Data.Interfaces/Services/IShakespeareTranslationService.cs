using System.Threading;
using System.Threading.Tasks;

namespace ShakespeareInPokemon.Data.Interfaces.Services
{
    public interface IShakespeareTranslationService
    {
        #region methods

        Task<string> GetTranslation(
            string textToTranslate,
            CancellationToken cancellationToken);

        #endregion  // methods
    }
}