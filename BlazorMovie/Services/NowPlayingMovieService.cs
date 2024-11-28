using BlazorMovie.Models;
using BlazorMovie.Services.Interfaces;

namespace BlazorMovie.Services
{
    public class NowPlayingMovieService : INowPlayingMovieService
    {
        private readonly TMDBClient _tmdbClient;

        public NowPlayingMovieService(TMDBClient tmdbClient)
        {
            _tmdbClient = tmdbClient;
        }


        public async Task<NowPlayingPageResponse> GetMoviesAsync(int page)
        {
            var response = await _tmdbClient.GetNowPlayingAsync(page) ?? throw new Exception("No movie data returned");

            return response;
        }
    }
}
