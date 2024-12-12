using System.Text.Json.Serialization;

namespace BlazorMovie.Models.Providers
{
    public class ProviderLink
    {
        [JsonPropertyName("link")]
        public string Link { get; set; } = string.Empty;
    }
}
