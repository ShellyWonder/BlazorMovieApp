using BlazorMovie.Models;
using BlazorMovie.Services.Interfaces;
using System.ComponentModel.DataAnnotations;


namespace BlazorMovie.Services
{
    public class SearchService : ISearchService
    {
        private readonly TMDBClient _TMDBClient;

        public SearchService(TMDBClient tMDBClient)
        {
            _TMDBClient = tMDBClient;
        }

        public async Task<IEnumerable<SearchModel>> GetSearchModelAsync(string Category, string SearchTerm)
        {
            Console.WriteLine($"SearchModelAsync called with Category: {Category}, SearchTerm: {SearchTerm}");
            var movieSearchResponse = await _TMDBClient.SearchMoviesByTitle(SearchTerm);

            if (movieSearchResponse?.Results != null && movieSearchResponse.Results.Any())
            {
                Console.WriteLine($"Results found: {movieSearchResponse.Results.Count()}");

                var searchModels = movieSearchResponse.Results.Select(movie => new SearchModel
                {
                    Category = Category,
                    SearchTerm = SearchTerm,
                    MovieDetails = movie
                });

                return searchModels;
            }

            Console.WriteLine("No results found.");
            return Enumerable.Empty<SearchModel>();
        }

        public async Task<IEnumerable<SearchModel>> GetMoviesByCategoryAsync(string category)
        {
            Console.WriteLine($"Fetching movies for category: {category}");
            IEnumerable<MovieDetails>? movies;

            if (category == "PopularMovies")
            {
                movies = (IEnumerable<MovieDetails>?)await _TMDBClient.GetPopularMoviesAsync();
            }
            else if (category == "TopRated")
            {
                movies = (IEnumerable<MovieDetails>?)await _TMDBClient.GetTopRatedAsync();
            }
            else if (category == "Upcoming")
            {
                movies = (IEnumerable<MovieDetails>?)await _TMDBClient.GetUpcomingAsync();
            }
            else if (category == "NowPlaying")
            {
                movies = (IEnumerable<MovieDetails>?)await _TMDBClient.GetNowPlayingAsync();
            }
            else
            {
                movies = null;
            }

            return movies?.Select(movie => new SearchModel
            {
                Category = category,
                MovieDetails = movie
            }) ?? Enumerable.Empty<SearchModel>();
        }

    }
}



