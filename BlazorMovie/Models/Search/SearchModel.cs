using BlazorMovie.Enums;
using BlazorMovie.Models.Credits;

namespace BlazorMovie.Models.Search
{
    public class SearchModel
    {
        public SearchCategory Category { get; set; } = SearchCategory.None;
        public string SearchTerm { get; set; } = string.Empty;
        public string Query {  get; set; } = string.Empty;

        public MovieDetails? MovieDetails { get; set; }
        public PersonDetails? PersonDetails { get; set; }

    }
}
