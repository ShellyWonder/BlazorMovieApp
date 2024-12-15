using BlazorMovie.Models.Credits;

namespace BlazorMovie.Services.Interfaces
{
    public interface ICreditService
    {
        Task<Credit> GetCreditsAsync(int movieId);
    }
}
