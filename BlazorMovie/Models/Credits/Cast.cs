using System.Text.Json.Serialization;

namespace BlazorMovie.Models.Credits
{
    public class Cast : Person 
    {
        [JsonPropertyName("cast_id")]
        public int CastId { get; set; }

        [JsonPropertyName("character")]
        public string Character { get; set; } = string.Empty;

        [JsonPropertyName("order")]
        public int Order { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("release_date")]
        public string? ReleaseDate { get; set; }

        [JsonPropertyName("vote_average")]
        public float VoteAverage { get; set; }

        [JsonPropertyName("poster_path")]
        public string? PosterPath { get; set; }
    }

}
