using BlazorMovie.Models;
using BlazorMovie.Utilities;
using BlazorMovie.Services.Interfaces;

namespace BlazorMovie.Services
{
    public class UpcomingComingSoonService :  IMovieService
    {
        private readonly TMDBClient _tmdbClient;

        public UpcomingComingSoonService(TMDBClient tmdbClient)
        {
            _tmdbClient = tmdbClient;
        }

        public  async Task<PageResponse<Movie>?> GetMoviesAsync(int page)
        {
            var response = await _tmdbClient.GetUpcomingAsync(page) ?? throw new Exception("No movie data returned");
            // Map PageResponse<Upcoming> to PageResponse<Movie>
            return MovieServiceHelperUtility.MapToMoviePageResponse(response);// Cast Upcoming to Movie
            
        }
    }
}
