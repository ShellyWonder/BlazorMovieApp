using BlazorMovie.Mappers;
using BlazorMovie.Models;
using BlazorMovie.Models.Credits;
using BlazorMovie.Services.Interfaces;

namespace BlazorMovie.Services
{
    public class CreditService : ICreditService
    {
        private readonly TMDBClient _tmdbClient;
        
        #region CONSTRUCTOR
        public CreditService(TMDBClient tmdbClient)
        {
            _tmdbClient = tmdbClient;
            
        }
        #endregion

        #region GET CREDITS
        public async Task<(List<Cast> Cast, List<Crew> Crew)> GetCreditsAsync(int movieId)
        {
            var response = await _tmdbClient.GetCreditsByMovieIdAsync(movieId) ?? throw new Exception("No credit data returned");
            var cast = CreditsMapper.MapCast(response.Cast);
            var crew = CreditsMapper.MapCrew(response.Crew);

            return (Cast: cast, Crew: crew);
        }
        #endregion

        #region GET MOVIES BY PERSON ID
        public async Task<PageResponse<MovieWithCharacter>> GetMoviesByPersonIdAsync(int personId, int page = 1)
        {
            var creditResponse = await _tmdbClient.GetMovieCreditsByPersonIdAsync(personId);
            if (creditResponse?.Cast == null || !creditResponse.Cast.Any())
            {
                throw new Exception("No movie credits found.");
            }
            var movieIds = creditResponse.Cast.Select(c => c.Id).Distinct().ToList();
            var movieDetailTasks = movieIds.Select(id => _tmdbClient.GetMovieDetailsAsync(id));
            var movieDetails = await Task.WhenAll(movieDetailTasks);

            var moviesWithCharacter = movieDetails
                .Where(movie => movie != null)
                .Select(movie =>
                {
                    if (movie == null)
                        return null;

                    return new MovieWithCharacter
                    {
                        Id = movie.Id,
                        Title = movie.Title ?? "Unknown Title",
                        PosterPath = movie.PosterPath ?? string.Empty,
                        ReleaseDate = movie.ReleaseDate ?? "Unknown Date",
                        VoteAverage = movie.VoteAverage,
                        Character = creditResponse.Cast.FirstOrDefault(c => c.Id == movie.Id)?.Character ?? "Unknown"
                    };
                })
                .Where(m => m != null)
                .Cast<MovieWithCharacter>()
                .ToList();

            var pageSize = 10;
            var paginatedResults = moviesWithCharacter.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            return new PageResponse<MovieWithCharacter>
            {
                Page = page,
                TotalPages = (int)Math.Ceiling((double)moviesWithCharacter.Count / pageSize),
                TotalResults = moviesWithCharacter.Count,
                Results = paginatedResults
            };
        }
        #endregion
    }
}
