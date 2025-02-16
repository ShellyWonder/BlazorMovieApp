using System.Text.Json.Serialization;

namespace BlazorMovie.Models.Credits
{
    public class PersonDetailsWithCredits : PersonDetails
    {
        [JsonPropertyName("movie_credits")]
        public MovieCredits? MovieCredits { get; set; }
    }
}
