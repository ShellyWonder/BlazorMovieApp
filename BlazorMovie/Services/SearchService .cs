using global::BlazorMovie.Models;
using BlazorMovie.Services.Interfaces;
using BlazorMovie.Models.Search;
using BlazorMovie.Models.Dtos;

namespace BlazorMovie.Services
{
    public class SearchService : ISearchService
    {
        private readonly TMDBClient _tmdbClient;

        #region CONSTRUCTOR
        public SearchService(TMDBClient tmdbClient)
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
        public async Task<PageResponse<PersonSearchResult>?> GetPersonAsync(int page, string searchQuery = "")
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


        //passed to the Search component; calls GetMoviesAsync() or GetPersonAsync() based on search type
        public async Task<object?> HandleSearchAsync(string category, string searchQuery, int page = 1)
        {
            if (string.IsNullOrEmpty(category))
            {
                throw new ArgumentNullException(nameof(category));
            }

            if (string.IsNullOrEmpty(searchQuery))
            {
                throw new ArgumentNullException(nameof(searchQuery));
            }

            return category switch
            {
                "MovieByTitle" => await GetMoviesAsync(page, searchQuery),
                "PersonByName" => await GetPersonAsync(page, searchQuery),
                _ => throw new ArgumentException("Invalid search category", nameof(category)),
            };
        }
    }
}

