using BlazorMovie.Mappers;
using BlazorMovie.Models;
using BlazorMovie.Models.Credits;
using BlazorMovie.Models.Dtos;
using BlazorMovie.Services.Interfaces;
using BlazorMovie.Utilities;


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
        public async Task<PageResponse<MovieCastDto>> GetMoviesByPersonIdAsync(int personId, int page = 1)
        {
            var creditResponse = await _tmdbClient.GetMovieCreditsByPersonIdAsync(personId);
            if (creditResponse?.Cast == null || creditResponse.Cast.Length == 0)
            {
                throw new Exception("No movie credits found.");
            }
            var castList = creditResponse.Cast;


            var dtos = castList.Select(c => new MovieCastDto
            {
                CastId = c.CastId,               
                Character = c.Character,
                Id = c.Id,                  
                Title = c.Title,        
                PosterPath = c.PosterPath,         
                ReleaseDate = c.ReleaseDate,                   
                VoteAverage = c.VoteAverage                     
            }).ToList();


            return PaginationUtility.PaginateList(dtos, page, 10);
        }
        #endregion

        #region GET PERSON DETAILS WITH CREDITS
        public async Task<PersonWithCreditsDto> GetPersonDetailsWithCredits(int personId, int page = 1)
        {
            // Single call to fetch both person details and credits
            var data = await _tmdbClient.GetPersonDetailsWithCreditsById(personId);
            // If no credits returned, handle accordingly
            if (data.MovieCredits?.Cast == null || data.MovieCredits.Cast.Length == 0)
            {
                throw new Exception("No movie credits found.");
            }

            var castDtos = data.MovieCredits?.Cast ?? [];

            var pageResponse = PaginationUtility.PaginateList(castDtos, page, 10);
            
            return new PersonWithCreditsDto
            {
                PersonDetails = data, // includes the overall PersonDetails
                MovieCredits = pageResponse // a PageResponse<MovieCastDto>
            };
        }
    }
  #endregion

}
