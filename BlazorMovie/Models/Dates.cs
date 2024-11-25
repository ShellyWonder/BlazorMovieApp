using System.Text.Json.Serialization;

namespace BlazorMovie.Models
{
    public class Dates
    {
        [JsonPropertyName("maximum")]
        public DateTime? Maximum { get; set; }

        [JsonPropertyName("minimum")]
         public DateTime? Minimum { get; set; } 
    }

}
