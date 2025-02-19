namespace BlazorMovie.Models.Search
{
    public class SearchModel
    {
        public string Category { get; set; } = string.Empty;
        public string SearchTerm { get; set; } = string.Empty;
        public string Query {  get; set; } = string.Empty;

        public MovieDetails? MovieDetails { get; set; }

    }
}
