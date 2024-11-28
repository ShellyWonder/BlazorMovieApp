using BlazorMovie.Models;
using BlazorMovie.Services.Interfaces;

namespace BlazorMovie.Services
{
    public class TopRatedService : IMovieService<TopRated>
    {
        private readonly TMDBClient _tmdbClient;

        public TopRatedService(TMDBClient tmdbClient)
        {
            _tmdbClient = tmdbClient;
        }

        public  async Task<PageResponse<TopRated>> GetMoviesAsync(int page)
        {
            return await _tmdbClient.GetTopRatedAsync(page) ?? throw new Exception("No movie data returned");
        }

        
    }
}
