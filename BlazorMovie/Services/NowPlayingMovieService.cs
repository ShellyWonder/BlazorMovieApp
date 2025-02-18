using BlazorMovie.Models;
using BlazorMovie.Services.Interfaces;
using BlazorMovie.Utilities;

namespace BlazorMovie.Services
{
    public class NowPlayingMovieService : IMovieService
    {
        private readonly TMDBClient _tmdbClient;

        public NowPlayingMovieService(TMDBClient tmdbClient)
        {
            _tmdbClient = tmdbClient;
        }

        public async Task<PageResponse<Movie>?> GetMoviesAsync(int page)
        {
            var response = await _tmdbClient.GetNowPlayingAsync(page) ?? throw new Exception("No movie data returned");
            return MovieServiceHelperUtility.MapToMoviePageResponse(response);
        }
    }

}
