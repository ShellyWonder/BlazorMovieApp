using BlazorMovie.Models;
using BlazorMovie.Models.Interfaces;
using System.Reflection.Metadata;


namespace BlazorMovie.Services
{
    public class SearchService : ISearchService
    {
        private readonly TMDBClient _TMDBClient;

        public SearchService(TMDBClient tMDBClient)
        {
            _TMDBClient = tMDBClient;
        }

        public async Task<IEnumerable<SearchModel>> GetSearchModelAsync(string Category, string SearchTerm)
        {
            if (Category == "Movie By Title")
            {
                var movieDetails = await _TMDBClient.GetMovieByTitleAsnyc(SearchTerm);
                
                if (movieDetails != null)
                {
                    var searchModel = new SearchModel
                    {
                        Category  = Category,
                        SearchTerm = SearchTerm,
                        MovieDetails = movieDetails
                    };
                    return new[] { searchModel };

                }
            }
           
            return Enumerable.Empty<SearchModel>();
        }
    }
}
    

