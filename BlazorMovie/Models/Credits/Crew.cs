using System.Text.Json.Serialization;

namespace BlazorMovie.Models.Credits
{
    public class Crew : Person
    {

        [JsonPropertyName("department")]
        public string Department { get; set; } = string.Empty;

        [JsonPropertyName("job")]
        public string Job { get; set; } = string.Empty;
    }

    }
