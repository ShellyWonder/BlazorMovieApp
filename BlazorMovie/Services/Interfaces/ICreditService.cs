using BlazorMovie.Models;
using BlazorMovie.Models.Credits;
using BlazorMovie.Models.Dtos;

namespace BlazorMovie.Services.Interfaces
{
    public interface ICreditService
    {
        Task<(List<Cast> Cast, List<Crew> Crew)> GetCreditsAsync(int movieId);

        Task<PageResponse<MovieWithCharacter>> GetMoviesByPersonIdAsync(int personId, int page = 1);
        Task<PersonWithCreditsDto> GetPersonDetailsWithCredits(int personId, int page = 1);
    }
}
