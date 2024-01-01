namespace BlazorMovie.Models.Interfaces
{
    public interface ISearchService
    {
        Task<IEnumerable<SearchModel>> GetSearchModelAsync(string Category, string SearchTerm);
    }
}
