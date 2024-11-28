using BlazorMovie.Models;
using BlazorMovie.Models.Interfaces;

namespace BlazorMovie.Services.Interfaces
{
    public interface IMovieService<T> where T : IMovie
    {
        Task<PageResponse<T>> GetMoviesAsync(int page);
    }
}
