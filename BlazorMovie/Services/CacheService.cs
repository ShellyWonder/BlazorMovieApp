using Microsoft.JSInterop;
using System.Text.Json;

namespace BlazorMovie.Services
{
    public class CacheService
    {
        private readonly IJSRuntime _jsRuntime;

        public CacheService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task<T?> GetOrFetchAsync<T>(
            Func<Task<T?>> fetchFunc,
            string baseCacheKey,
            object? queryParameters = null)
        {
            try
            {
                // Construct the cache key with optional query parameters
                var cacheKey = queryParameters != null
                    ? $"{baseCacheKey}_{JsonSerializer.Serialize(queryParameters)}"
                    : baseCacheKey;

                // Check if data exists in sessionStorage
                var cachedJson = await _jsRuntime.InvokeAsync<string>("sessionStorageHelper.getItem", cacheKey);
                if (!string.IsNullOrEmpty(cachedJson))
                {
                    return JsonSerializer.Deserialize<T>(cachedJson);
                }

                // Fetch data if not available in cache
                var dataFromApi = await fetchFunc();
                if (dataFromApi != null)
                {
                    // Store the fetched data in sessionStorage
                    var jsonData = JsonSerializer.Serialize(dataFromApi);
                    await _jsRuntime.InvokeVoidAsync("sessionStorageHelper.setItem", cacheKey, jsonData);
                }

                return dataFromApi;
            }
            catch (Exception ex)
            {
                // Log error
                Console.WriteLine($"Error in GetOrFetchAsync: {ex.Message}");
                return default;
            }
        }
    }
}
