using BlazorMovie.Mappers;
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
            var response = await _tmdbClient.GetCreditsByMovieIdAsync(movieId);

            if (response == null)
            {
                throw new Exception("No credit data returned");
            }

            var cast = CreditsMapper.MapCast(response.Cast);
            var crew = CreditsMapper.MapCrew(response.Crew);

            return (Cast: cast, Crew: crew);
        }
        #endregion

        #region GET CREDITS BY PERSON ID
        public async Task<Credit?> GetMovieCreditsByPersonIdAsync(int personId) 
        { 
            return await _tmdbClient.GetMovieCreditsByPersonIdAsync(personId);
            
        }
        #endregion
    }
}
