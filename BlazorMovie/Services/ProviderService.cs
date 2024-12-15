using BlazorMovie.Models.Providers;
using BlazorMovie.Services.Interfaces;

namespace BlazorMovie.Services
{
    public class ProviderService(TMDBClient tmdbClient) : IProviderService
    {
        private readonly TMDBClient _tmdbClient = tmdbClient;

        public async Task<ProviderDetail<ProviderOption, ProviderOption, ProviderOption>?> GetProvidersAsync(int id)
        {
            var response = await _tmdbClient.GetProvidersByMovieIdAsync(id) 
                                                                            ?? throw new Exception("No provider data returned");
            return response;
        }
    }
}
