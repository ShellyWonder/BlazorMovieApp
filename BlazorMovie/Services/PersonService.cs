using BlazorMovie.Models.Credits;
using BlazorMovie.Services.Interfaces;

namespace BlazorMovie.Services
{
    public class PersonService : IPersonService
    {
        private readonly TMDBClient _tmdbClient;

        #region CONSTRUCTOR
        public PersonService(TMDBClient tmdbClient)
        {
            _tmdbClient = tmdbClient;
        }
        #endregion

        #region GET PERSON DETAILS
        public async Task<PersonDetails>GetPersonDetails(int personId)
        {
            var Details = await _tmdbClient.GetPersonDetailsById(personId) 
                                      ?? throw new Exception("No details returned");
            return Details;
        }
        #endregion
    }
}
