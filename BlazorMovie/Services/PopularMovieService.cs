using BlazorMovie.Models;

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
           
            var result = await _tmdbClient.GetPopularMoviesAsync(page) ?? throw new Exception("No movie data returned");
            return result;
        }
    }



}


