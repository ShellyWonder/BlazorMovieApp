using BlazorMovie.Models;

namespace BlazorMovie.Services.Interfaces
{

    public interface IMovieService
    {
        Task<PageResponse<Movie>?> GetMoviesAsync(int page);
        Task<PageResponse<Movie>?> GetMoviesAsync(int page, string searchQuery = "");
    }
}
