using BlazorMovie.Models;
using BlazorMovie.Services.Interfaces;

namespace BlazorMovie.Services
{
    public class PopularMovieService : IMovieService<PopularMovie>
    {
        private readonly TMDBClient _tmdbClient;

        public PopularMovieService(TMDBClient tmdbClient)
        {
            _tmdbClient = tmdbClient;
        }

        
       public async Task<PageResponse<PopularMovie>> GetMoviesAsync(int page)
        {
            return await _tmdbClient.GetPopularMoviesAsync(page) ?? throw new Exception("No movie data returned");
        }
    }


}


