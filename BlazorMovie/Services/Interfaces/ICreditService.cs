using BlazorMovie.Models.Credits;

namespace BlazorMovie.Services.Interfaces
{
    public interface ICreditService
    {
        Task<(List<Cast> Cast, List<Crew> Crew)> GetCreditsAsync(int movieId);
    }
}
