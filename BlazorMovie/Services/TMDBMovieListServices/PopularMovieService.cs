using BlazorMovie.Models;
using BlazorMovie.Services.Interfaces;
using BlazorMovie.Utilities;

namespace BlazorMovie.Services.TMDBMovieListServices
{
    public class PopularMovieService : IMovieService
    {
        private readonly TMDBClient _tmdbClient;

        public PopularMovieService(TMDBClient tmdbClient)
        {
            _tmdbClient = tmdbClient;
        }

        public async Task<PageResponse<Movie>?> GetMoviesAsync(int page)
        {
            var response = await _tmdbClient.GetPopularMoviesAsync(page) ?? throw new Exception("No movie data returned");

            return MovieServiceHelperUtility.MapToMoviePageResponse(response);
        }

    }
}


