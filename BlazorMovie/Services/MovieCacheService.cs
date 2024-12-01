using Microsoft.JSInterop;
using BlazorMovie.Models;
using System.Text.Json;

namespace BlazorMovie.Services
{
    public class MovieCacheService
    {
        private readonly IJSRuntime _jsRuntime;

        public MovieCacheService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task<PageResponse<Movie>?> GetOrFetchMoviesAsync(
            Func<int, Task<PageResponse<Movie>?>> fetchFunc,
            string cacheKey,
            int page)
        {
            string fullCacheKey = $"{cacheKey}{page}";

            try
            {
                // Check if data exists in sessionStorage
                var cachedMoviesJson = await _jsRuntime.InvokeAsync<string>("sessionStorageHelper.getItem", fullCacheKey);
                if (!string.IsNullOrEmpty(cachedMoviesJson))
                {
                    return JsonSerializer.Deserialize<PageResponse<Movie>>(cachedMoviesJson);
                }

                // Fetch data if not available in cache
                var moviesFromApi = await fetchFunc(page);
                if (moviesFromApi != null)
                {
                    // Store the fetched movies in sessionStorage
                    await _jsRuntime.InvokeVoidAsync("sessionStorageHelper.setItem", fullCacheKey, moviesFromApi);
                }

                return moviesFromApi;
            }
            catch (Exception ex)
            {
                // Log error
                Console.WriteLine($"Error in GetOrFetchMoviesAsync: {ex.Message}");
                return null;
            }
        }
    }
}
