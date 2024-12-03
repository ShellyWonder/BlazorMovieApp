using BlazorMovie.Models;

namespace BlazorMovie.Services.Interfaces
{
    public interface ISearchMovieService : IBaseMovieService
    {
        Task<PageResponse<Movie>?> GetMoviesAsync(int page, string searchQuery = "");
    }
}
