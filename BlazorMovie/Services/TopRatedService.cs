using BlazorMovie.Models;
using BlazorMovie.Services.Interfaces;
using BlazorMovie.Utilities;

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
            return MovieServiceHelperUtility.MapToMoviePageResponse(response);
        }
    }
}
