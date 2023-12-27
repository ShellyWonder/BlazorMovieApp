using System.Text.Json.Serialization;

namespace BlazorMovie.Models
{
    public class Dates
        {
        [JsonPropertyName("maximum")]
            public string Maximum { get; set; } = string.Empty;

        [JsonPropertyName("minimum")]
            public string Minimum { get; set; } = string.Empty;
        }

 

    
}
