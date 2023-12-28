using BlazorMovie.Models;
using BlazorMovie.Models.Interfaces;

namespace BlazorMovie.Services
{
    public class TopRatedService : IMovieService<Result>
    {
        private readonly TMDBClient _tmdbClient;

        public TopRatedService(TMDBClient tmdbClient)
        {
            _tmdbClient = tmdbClient;
        }

        public  async Task<PageResponse<Result>> GetMoviesAsync(int page)
        {
            return await _tmdbClient.GetTopRatedAsync(page) ?? throw new Exception("No movie data returned");
        }
    }
}
