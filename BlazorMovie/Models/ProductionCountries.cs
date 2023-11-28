using System.Text.Json.Serialization;

namespace BlazorMovie.Models
{
    public class ProductionCountries
    {

        [JsonPropertyName("iso_3166_1")]
        public string? Iso31661 { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
