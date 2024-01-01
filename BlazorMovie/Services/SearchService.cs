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
            if (Category == "Movie")
            {
                var movieDetails = await _TMDBClient.GetMovieByTitle(SearchTerm);
                if (movieDetails != null)
                {
                    var searchModel = new SearchModel
                    {
                        Category = "Movie",
                        SearchTerm = SearchTerm,
                        MovieDetails = movieDetails
                    };
                    return new[] { searchModel };
                }
            }
            //else if (Category == "Actor")
            //{
            //    var actorDetails = await _TMDBClient.GetActorByName(SearchTerm);
            //    if (actorDetails != null)
            //    {
            //        var searchModel = new SearchModel
            //        {
            //            Category = "Actor",
            //            SearchTerm = SearchTerm,
            //            ActorDetails = actorDetails
            //        };
            //        return new[] { searchModel };
            //    }
            //}
            // Handle other categories or return null / empty IEnumerable
            return Enumerable.Empty<SearchModel>();
        }
    }
}
    

