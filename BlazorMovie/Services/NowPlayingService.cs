using BlazorMovie.Models;

namespace BlazorMovie.Services
{
    public class NowPlayingService : NowPlaying
    {
       private readonly TMDBClient _tmdbClient;

        public NowPlayingService(TMDBClient tmdbClient)
        {
            _tmdbClient = tmdbClient;
        }

        public  async Task<NowPlayingPageResponse> GetMoviesAsync(int page)
            {
            var result = await _tmdbClient.GetNowPlayingAsync(page) ?? throw new Exception("No movie data returned");
            return result;
        }
        

    }
}
