using System.Text.Json.Serialization;

namespace BlazorMovie.Models.Credits
{
    public class PersonDetails : Person
    {
        [JsonPropertyName("also_known_as")]
        public string[] AKA { get; set; } = [];

        [JsonPropertyName("biography")]
        public string Biography { get; set; } = string.Empty;
        
        [JsonPropertyName("birthday")]
        public string Birthdate { get; set; }

        [JsonPropertyName("deathday")]
        public object Deathdate { get; set; }

        [JsonPropertyName("homepage")]
        public object Homepage { get; set; } = string.Empty;

        [JsonPropertyName("imdb_id")]
        public string ImdbId { get; set; } = string.Empty;

        [JsonPropertyName("place_of_birth")]
        public string Birthplace { get; set; } = string.Empty;
           
    }

    
}
