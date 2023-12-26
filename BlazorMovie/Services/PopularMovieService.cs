using BlazorMovie.Models;
using BlazorMovie.Models.Interfaces;

namespace BlazorMovie.Services
{
    public class PopularMovieService : PopularMovie
    {
        private readonly TMDBClient _tmdbClient;

        public PopularMovieService(TMDBClient tmdbClient)
        {
            _tmdbClient = tmdbClient;
        }
        public async Task<PopularMoviesPageResponse> GetMoviesAsync(int page)
        {
            if (page < 1) page = 1;
            else if (page > 500) page = 500;

            var result = await _tmdbClient.GetPopularMoviesAsync(1) ?? throw new Exception("No movie data returned");
            return result;
        }
    }



}


