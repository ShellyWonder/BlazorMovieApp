using BlazorMovie.Models;

namespace BlazorMovie.Services.Interfaces
{

    public interface IMovieService : IBaseMovieService
    {
        Task<PageResponse<Movie>?> GetMoviesAsync(int page);
       
    }
}
