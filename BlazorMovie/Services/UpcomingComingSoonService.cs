using BlazorMovie.Models;
using BlazorMovie.Services.Interfaces;

namespace BlazorMovie.Services
{
    public class UpcomingComingSoonService : IMovieService<Upcoming>
    {
        private readonly TMDBClient _tmdbClient;

        public UpcomingComingSoonService(TMDBClient tmdbClient)
        {
            _tmdbClient = tmdbClient;
        }

        public  async Task<PageResponse<Upcoming>> GetMoviesAsync(int page)
        {
            return await _tmdbClient.GetUpcomingAsync(page) ?? throw new Exception("No movie data returned");
        }
    }
}
