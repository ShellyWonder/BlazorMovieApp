using BlazorMovie.Models.Dtos;
using System.Text.Json.Serialization;

namespace BlazorMovie.Models.Credits
{
    public class MovieCredits
    {
        [JsonPropertyName("cast")]
        public MovieCastDto[] Cast { get; set; } = [];

        [JsonPropertyName("crew")]
        public Crew[] Crews { get; set; } = [];
    }
}
