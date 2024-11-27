using BlazorMovie.Models;
using BlazorMovie.Models.Interfaces;

namespace BlazorMovie.Services
{
    public class NowPlayingService : INowPlayingMovieService
    {
        private readonly TMDBClient _tmdbClient;

        public NowPlayingService(TMDBClient tmdbClient)
        {
            _tmdbClient = tmdbClient;
        }


        public async Task<NowPlayingPageResponse> GetMoviesAsync(int page)
        {
            var response = await _tmdbClient.GetNowPlayingAsync(page) ?? throw new Exception("No movie data returned");

            if (response.Dates != null && response.Results != null)
            {
                response.Results = response.Results
                                           .Where(movie => {
                                               // Parse ReleaseDate and ensure it's within the range
                                               if (DateTime.TryParse(movie.ReleaseDate, out var releaseDate))
                                               {
                                                   return releaseDate >= response.Dates.Minimum && releaseDate <= response.Dates.Maximum;
                                               }
                                               return false; // Exclude movies with invalid or null ReleaseDate
                                           })
                                           .OrderByDescending(movie => movie.ReleaseDate)
                                            .ToList();
            }

            return response;
        }
    }
}
