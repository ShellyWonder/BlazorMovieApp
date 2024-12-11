using System.Text.Json.Serialization;

namespace BlazorMovie.Models.Credits
{

    public class Credit
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("cast")]
        public Cast[] Cast { get; set; } = [];

        [JsonPropertyName("crew")]
        public Crew[] Crew { get; set; } = [];
    }

}
