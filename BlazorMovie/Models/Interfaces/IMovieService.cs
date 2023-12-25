namespace BlazorMovie.Models.Interfaces
{
    public interface IMovieService<TMovie> where TMovie : IMovie
    {
        Task<IEnumerable<TMovie>> GetMoviesAsync(int page); 
    }
}
