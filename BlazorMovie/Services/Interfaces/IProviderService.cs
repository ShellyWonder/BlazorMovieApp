using BlazorMovie.Models.Providers;

namespace BlazorMovie.Services.Interfaces
{
    public interface IProviderService
    {
        Task<ProviderDetail<ProviderOption, ProviderOption, ProviderOption>?> GetProvidersAsync(int id);
    }
}
