using System.Text.Json.Serialization;

namespace BlazorMovie.Models
{
    public class SpokenLanguages
    {

        [JsonPropertyName("english_name")]
        public string? EnglishName { get; set; }

        [JsonPropertyName("iso_639_1")]
        public string? Iso_639_1 { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
