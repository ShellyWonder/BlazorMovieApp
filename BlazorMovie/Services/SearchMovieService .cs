
using global::BlazorMovie.Models;
using BlazorMovie.Services.Interfaces;

namespace BlazorMovie.Services
{
    public class SearchMovieService : IMovieService
    {
        private readonly TMDBClient _tmdbClient;

        public SearchMovieService(TMDBClient tmdbClient)
        {
            _tmdbClient = tmdbClient;
        }

        public async Task<PageResponse<Movie>?> GetMoviesAsync(int page)
        {
            Console.WriteLine($"Fetching popular movies for page: {page}");
            return await _tmdbClient.GetPopularMoviesAsync(page); // Assuming GetPopularMoviesAsync is defined in TMDBClient
        }

        public async Task<PageResponse<Movie>?> GetMoviesAsync(int page, string searchQuery = "")
        {
            // Ensure searchQuery is provided for searches
            if (string.IsNullOrWhiteSpace(searchQuery))
                throw new ArgumentException("Search query cannot be empty for search operations.", nameof(searchQuery));

            Console.WriteLine($"Search called with query: {searchQuery}, page: {page}");

            var response = await _tmdbClient.SearchMoviesByTitle(searchQuery, page);

            if (response?.Results == null || !response.Results.Any())
            {
                Console.WriteLine("No results found.");
                return null;
            }

            Console.WriteLine($"Found {response.Results.Count()} results.");
            return response;
        }
    }
}

