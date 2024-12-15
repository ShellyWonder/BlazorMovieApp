using BlazorMovie.Models.Credits;
using BlazorMovie.Services.Interfaces;

namespace BlazorMovie.Services
{
    public class CreditService : ICreditService
    {
        private readonly TMDBClient _tmdbClient;

        public CreditService(TMDBClient tmdbClient)
        {
            _tmdbClient = tmdbClient;
        }
        public async Task<Credit> GetCreditsAsync(int movieId)
        {
              var response = await _tmdbClient.GetCreditsByMovieIdAsync(movieId);
            return response == null ? throw new Exception("No credit data returned") : response;
        }

    }
}
