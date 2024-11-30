using System.Text.Json.Serialization;

namespace BlazorMovie.Models
{
    public class Movie
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("poster_path")]
        public string? PosterPath { get; set; }

        [JsonPropertyName("release_date")]
        public string? ReleaseDate { get; set; }

        [JsonPropertyName("popularity")]
        public float Popularity { get; set; }

        [JsonPropertyName("backdrop_path")]
        public string BackdropPath { get; set; } = string.Empty;
    }
}
