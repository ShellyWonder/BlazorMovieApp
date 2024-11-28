using BlazorMovie.Models;
using Microsoft.JSInterop;
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

        public async Task<PageResponse<TMovie>?> GetOrFetchMoviesAsync<TMovie>(
            Func<int, Task<PageResponse<TMovie>?>> fetchMoviesFunc,
            string cacheKey,
            int page)
        {
            var cachedMoviesJson = await _jsRuntime.InvokeAsync<string>("sessionStorageHelper.getItem", $"{cacheKey}{page}");

            if (!string.IsNullOrEmpty(cachedMoviesJson))
            {
                return JsonSerializer.Deserialize<PageResponse<TMovie>>(cachedMoviesJson);
            }

            var movies = await fetchMoviesFunc(page);

            if (movies != null)
            {
                var moviesJson = JsonSerializer.Serialize(movies);
                await _jsRuntime.InvokeVoidAsync("sessionStorageHelper.setItem", $"{cacheKey}{page}", moviesJson);
            }

            return movies;
        }
    }

}
