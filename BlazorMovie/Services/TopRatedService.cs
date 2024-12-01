using BlazorMovie.Models;
using BlazorMovie.Services.Interfaces;

namespace BlazorMovie.Services
{
    public class TopRatedService : IMovieService
    {
        private readonly TMDBClient _tmdbClient;

        public TopRatedService(TMDBClient tmdbClient)
        {
            _tmdbClient = tmdbClient;
        }

        public async Task<PageResponse<Movie>?> GetMoviesAsync(int page)
        {
            var response = await _tmdbClient.GetTopRatedAsync(page) ?? throw new Exception("No movie data returned");
            // Map PageResponse<TopRated> to PageResponse<Movie>
            return new PageResponse<Movie>
            {
                Page = response.Page,
                TotalPages = response.TotalPages,
                TotalResults = response.TotalResults,
                Dates = response.Dates,
                Results = response.Results.Cast<Movie>().ToList() // Cast TopRated to Movie
            };
        }
    }
}
