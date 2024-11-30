using System.Text.Json.Serialization;

namespace BlazorMovie.Models
{
    public class Movie
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        [JsonPropertyName("poster_path")]
        public string? PosterPath { get; set; }

        [JsonPropertyName("release_date")]
        public string? ReleaseDate { get; set; }

        [JsonPropertyName("popularity")]
        public float Popularity { get; set; }

        [JsonPropertyName("overview")]
        public string Overview { get; set; } = String.Empty;

        [JsonPropertyName("backdrop_path")]
        public string BackdropPath { get; set; } = string.Empty;

        [JsonPropertyName("vote_average")]
        public float VoteAverage { get; set; }

        [JsonPropertyName("original_title")]
        public string OriginalTitle { get; set; } = String.Empty;

        [JsonPropertyName("original_language")]
        public string OriginalLanguage { get; set; } = String.Empty;
        
        [JsonPropertyName("genre_ids")]
        public List<int> GenreIds { get; set; } = new();


        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }

        [JsonPropertyName("video")]
        public bool Video { get; set; }
    }
}
