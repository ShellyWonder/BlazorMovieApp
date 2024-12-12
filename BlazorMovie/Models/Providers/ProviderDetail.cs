using System.Text.Json.Serialization;

namespace BlazorMovie.Models.Providers
{
    public class ProviderDetail : ProviderLink
    {
       [JsonPropertyName("flatrate")]
        public ProviderOption[] Flatrate { get; set; } = Array.Empty<ProviderOption>();

        [JsonPropertyName("rent")]
        public ProviderOption[] Rent { get; set; } = Array.Empty<ProviderOption>();

        [JsonPropertyName("buy")]
        public ProviderOption[] Buy { get; set; } = Array.Empty<ProviderOption>();
    }

    public class ProviderDetail<TFlatrate, TBuy, TRent> : ProviderLink
    where TFlatrate : ProviderOption
    where TBuy : ProviderOption
    where TRent : ProviderOption
    {
       public TFlatrate[] Flatrate { get; set; } = Array.Empty<TFlatrate>();
        public TBuy[] Buy { get; set; } = Array.Empty<TBuy>();
        public TRent[] Rent { get; set; } = Array.Empty<TRent>();
    }

}
