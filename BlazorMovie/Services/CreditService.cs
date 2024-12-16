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

            var cast = MapCast(response.Cast);
            var crew = MapCrew(response.Crew);

            return (Cast: cast, Crew: crew);
        }
        #endregion

        #region MAP CAST
        private List<Cast> MapCast(Cast[] castArray)
        {
            return castArray.Select(c => new Cast
            {
                Id = c.Id,
                Name = c.Name,
                ProfilePath = c.ProfilePath,
                KnownForDepartment = c.KnownForDepartment,
                CreditId = c.CreditId,
                Gender = c.Gender,
                Popularity = c.Popularity,
                CastId = c.CastId,
                Character = c.Character,
                Order = c.Order
            }).ToList();
        }
        #endregion

        #region MAP CREW
        private List<Crew> MapCrew(Crew[] crewArray)
        {
            return crewArray.Select(c => new Crew
            {
                Id = c.Id,
                Name = c.Name,
                ProfilePath = c.ProfilePath,
                KnownForDepartment = c.KnownForDepartment,
                CreditId = c.CreditId,
                Gender = c.Gender,
                Popularity = c.Popularity,
                Department = c.Department,
                Job = c.Job
            }).ToList();
        }
        #endregion
    }
}
