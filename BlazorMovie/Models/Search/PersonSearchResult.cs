using System.Text.Json.Serialization;

namespace BlazorMovie.Models.Search
{
    public class PersonSearchResult
    {
        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        [JsonPropertyName("gender")]
        public int Gender { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("known_for_department")]
        public string KnownForDepartment { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("original_name")]
        public string OriginalName { get; set; } = string.Empty;

        [JsonPropertyName("popularity")]
        public float Popularity { get; set; }

        [JsonPropertyName("profile_path")]
        public string ProfilePath { get; set; } = string.Empty;

        // This is the additional array the search endpoint returns
        [JsonPropertyName("known_for")]
        public List<Movie> KnownFor { get; set; } = [];
    }
}
