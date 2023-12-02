using System.Text.Json.Serialization;

namespace BlazorMovie.Models
{
    public class NowPlayingPageResponse
    {

        [JsonPropertyName("dates")]
        public Dates? Dates { get; set; }

        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("results")]
        public IEnumerable<NowPlaying> Results { get; set; } = [];

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }
    }




}
