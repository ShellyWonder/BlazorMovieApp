using System.Text.Json.Serialization;

namespace BlazorMovie.Models.Providers
{
    public class ProviderOption
    {
        [JsonPropertyName("logo_Path")]
        public string LogoPath { get; set; } = string.Empty;

        [JsonPropertyName("provider_id")]
        public int ProviderId { get; set; }

        [JsonPropertyName("provider_name")]
        public string ProviderName { get; set; } = string.Empty;

        [JsonPropertyName("display_priority")]
        public int DisplayPriorty { get; set; }

    }
}