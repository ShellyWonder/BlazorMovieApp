using System.Text.Json.Serialization;

namespace BlazorMovie.Models.Credits
{
    public class MovieWithCharacter : Movie
    {
        [JsonPropertyName("character")]
        public string Character { get; set; } = string.Empty;
        [JsonPropertyName("movie")]
        public Movie Movie { get; set; } = new();
    }

}
