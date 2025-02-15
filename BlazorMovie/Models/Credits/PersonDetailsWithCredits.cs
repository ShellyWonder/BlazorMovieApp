using System.Text.Json.Serialization;

namespace BlazorMovie.Models.Credits
{
    public class PersonDetailsWithCredits : PersonDetails
    {
        [JsonPropertyName("movie_credits")]
        public  Credit? MovieCredits { get; set; }
    }
}
