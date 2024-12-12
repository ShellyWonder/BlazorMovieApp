using BlazorMovie.Models.Credits;
using BlazorMovie.Models.Providers;
using System.Text.Json.Serialization;

namespace BlazorMovie.Models
{
    public class MovieDetails : Movie
    {

        [JsonPropertyName("belongs_to_collection")]
        public MovieCollection? BelongsToCollection { get; set; }

        [JsonPropertyName("budget")]
        public int Budget { get; set; }

        [JsonPropertyName("genres")]
        public Genre[] Genres { get; set; } = [];

        [JsonPropertyName("homepage")]
        public string? Homepage { get; set; }

        [JsonPropertyName("imdb_id")]
        public string? ImdbId { get; set; }

        [JsonPropertyName("production_companies")]
        public ProductionCompanies[] ProductionCompanies { get; set; } = [];

        [JsonPropertyName("credits")]
        public Credit Credits { get; set; } = new();

        [JsonPropertyName("providers")]
        public Provider? Providers { get; set; }

        [JsonPropertyName("production_countries")]
        public ProductionCountries[] ProductionCountries { get; set; } = [];

        [JsonPropertyName("revenue")]
        public int Revenue { get; set; }

        [JsonPropertyName("runtime")]
        public int Runtime { get; set; }

        [JsonPropertyName("spoken_languages")]
        public SpokenLanguages[] SpokenLanguages { get; set; } = [];

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("tagline")]
        public string? Tagline { get; set; }

    }
}
