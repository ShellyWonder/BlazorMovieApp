using BlazorMovie.Models.Interfaces;
using System.Text.Json.Serialization;

namespace BlazorMovie.Models
{
    public class Upcoming : IMovie
    {
        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        [JsonPropertyName("backdrop_path")]
        public string BackdropPath { get; set; } = String.Empty;

        [JsonPropertyName("genre_ids")]
        public int[] GenreIds { get; set; } = [];

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("original_language")]
        public string OriginalLanguage { get; set; } = String.Empty;

        [JsonPropertyName("original_title")]
        public string OriginalTitle { get; set; } = String.Empty;

        [JsonPropertyName("overview")]
        public string Overview { get; set; } = String.Empty;

        [JsonPropertyName("popularity")]
        public float Popularity { get; set; }

        [JsonPropertyName("poster_path")]
        public string? PosterPath { get; set; }

        [JsonPropertyName("release_date")]
        public string? ReleaseDate { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("video")]
        public bool Video { get; set; }

        [JsonPropertyName("vote_average")]
        public float VoteAverage { get; set; }

        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }
    }

}
