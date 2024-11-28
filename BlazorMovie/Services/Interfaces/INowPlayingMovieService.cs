using BlazorMovie.Models;

namespace BlazorMovie.Services.Interfaces
{
    public interface INowPlayingMovieService
    {
        Task<NowPlayingPageResponse> GetMoviesAsync(int page);
    }
}
