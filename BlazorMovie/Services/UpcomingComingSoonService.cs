using BlazorMovie.Models;
using BlazorMovie.Models.Interfaces;

namespace BlazorMovie.Services
{
    public class UpcomingComingSoonService : IMovieService<Result>
    {
        private readonly TMDBClient _tmdbClient;

        public UpcomingComingSoonService(TMDBClient tmdbClient)
        {
            _tmdbClient = tmdbClient;
        }

        public  async Task<PageResponse<Result>> GetMoviesAsync(int page)
        {
            return await _tmdbClient.GetUpcomingAsync(page) ?? throw new Exception("No movie data returned");
        }
    }
}
