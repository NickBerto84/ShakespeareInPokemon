using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ShakespeareInPokemon.Data.Interfaces.Wrappers
{
    public interface IHttpClientWrapper
    {
        #region methods

        Task<HttpResponseMessage> PostAsync(
            string requestUri,
            HttpContent content,
            CancellationToken cancellationToken);

        #endregion  // methods
    }
}