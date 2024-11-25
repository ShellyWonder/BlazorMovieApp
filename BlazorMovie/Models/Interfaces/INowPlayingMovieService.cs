namespace BlazorMovie.Models.Interfaces
{
    public interface INowPlayingMovieService
    {
        Task<NowPlayingPageResponse> GetMoviesAsync(int page);
    }
}
