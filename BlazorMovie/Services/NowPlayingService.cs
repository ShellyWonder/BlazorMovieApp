using BlazorMovie.Models;
using BlazorMovie.Models.Interfaces;

namespace BlazorMovie.Services
{
    public class NowPlayingService : INowPlayingMovieService
    {
        private readonly TMDBClient _tmdbClient;

        public NowPlayingService(TMDBClient tmdbClient)
        {
            _tmdbClient = tmdbClient;
        }


        public async Task<NowPlayingPageResponse> GetMoviesAsync(int page)
        {
            return await _tmdbClient.GetNowPlayingAsync(page) ?? throw new Exception("No movie data returned");
        }
    }
}
