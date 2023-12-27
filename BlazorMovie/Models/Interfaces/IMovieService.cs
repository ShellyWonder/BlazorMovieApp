namespace BlazorMovie.Models.Interfaces
{
    public interface IMovieService<T> where T : IMovie
    {
        Task<PageResponse<T>> GetMoviesAsync(int page);
    }
}
