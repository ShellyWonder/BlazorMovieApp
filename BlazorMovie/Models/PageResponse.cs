using System.Text.Json.Serialization;

namespace BlazorMovie.Models
{
    public class PageResponse<T>
    {
        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("results")]
        public List<T> Results { get; set; } =new();

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }

        // Explicit property for Dates, used only in Now Playing
        [JsonPropertyName("dates")]
        public Dates? Dates { get; set; }
    }
}
