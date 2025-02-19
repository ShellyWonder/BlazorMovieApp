
using global::BlazorMovie.Models;
using BlazorMovie.Services.Interfaces;
using BlazorMovie.Models.Search;

namespace BlazorMovie.Services
{
    public class SearchMovieService : ISearchMovieService
    {
        private readonly TMDBClient _tmdbClient;

        #region CONSTRUCTOR
        public SearchMovieService(TMDBClient tmdbClient)
        {
            _tmdbClient = tmdbClient;
        }
        #endregion

        #region GET MOVIES BY SEARCH QUERY
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
        #endregion

        #region GET PERSON BY SEARCH QUERY
        public async Task<PageResponse<PersonSearchResult>?>GetPersonAsync(int page, string searchQuery = "")
        {
            // Ensure searchQuery is provided for searches
            if (string.IsNullOrWhiteSpace(searchQuery))
                throw new ArgumentException("Search query cannot be empty for search operations.", nameof(searchQuery));
            Console.WriteLine($"Search called with query: {searchQuery}, page: {page}");
            var response = await _tmdbClient.SearchMoviesByPerson(searchQuery, page);
            if (response?.Results == null || response.Results.Count == 0)
            {
                Console.WriteLine("No results found.");
                return null;
            }
            Console.WriteLine($"Found {response.Results.Count()} results.");
            return response;
        }
        #endregion
    }
}

