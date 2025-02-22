using BlazorMovie.Models;

namespace BlazorMovie.Services.Interfaces
{
    public interface ISearchService : IBaseMovieService
    {
        Task<PageResponse<Movie>?> GetMoviesAsync(int page, string searchQuery = "");
    }
}
