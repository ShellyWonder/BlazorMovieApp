using BlazorMovie.Models;
using BlazorMovie.Models.Search;

namespace BlazorMovie.Services.Interfaces
{
    public interface ISearchService : IBaseMovieService
    {
        Task<PageResponse<Movie>?> GetMoviesAsync(int page, string searchQuery = "");
        Task<PageResponse<PersonSearchResult>?> GetPersonAsync(int page, string searchQuery = "");
        //Task<PageResponse<T>?> HandleSearchAsync<T>(string category, string searchQuery, int page = 1);
    }
}
