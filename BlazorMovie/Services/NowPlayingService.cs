using BlazorMovie.Models;
using BlazorMovie.Models.Interfaces;

namespace BlazorMovie.Services
{
    public class NowPlayingService : IMovieService<NowPlaying>
    {
        private readonly TMDBClient _tmdbClient;

        public NowPlayingService(TMDBClient tmdbClient)
        {
            _tmdbClient = tmdbClient;
        }


        public async Task<PageResponse<NowPlaying>> GetMoviesAsync(int page)
        {
            return await _tmdbClient.GetNowPlayingAsync(page) ?? throw new Exception("No movie data returned");
        }
    }
}
