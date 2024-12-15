using BlazorMovie.Models.Providers;
using BlazorMovie.Services.Interfaces;

namespace BlazorMovie.Services
{
    public class ProviderService(TMDBClient tmdbClient) : IProviderService
    {
        private readonly TMDBClient _tmdbClient = tmdbClient;

        public async Task<ProviderDetail<ProviderOption, ProviderOption, ProviderOption>?> GetProvidersAsync(int id)
        {
            return await _tmdbClient.GetProvidersByMovieIdAsync(id);
        }
    }
}
