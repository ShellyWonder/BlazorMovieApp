using System.Text.Json.Serialization;

namespace BlazorMovie.Models.Dtos
{
    public class ExtendedMovieDto : Movie
    {
        [JsonPropertyName("character")]
        public string? Character { get; set; }
    }
}
