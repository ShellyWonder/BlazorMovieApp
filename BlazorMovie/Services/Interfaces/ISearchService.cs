using BlazorMovie.Models;

namespace BlazorMovie.Services.Interfaces
{
    public interface ISearchService
    {
        Task<IEnumerable<SearchModel>> GetSearchModelAsync(string Category, string SearchTerm);
        Task<IEnumerable<SearchModel>> GetMoviesByCategoryAsync(string category);
        public List<KeyValuePair<string, string>> GetCategoryOptions();

    }
}
