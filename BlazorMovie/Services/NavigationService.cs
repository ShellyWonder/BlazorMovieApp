using BlazorMovie.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorMovie.Services
{
    public class NavigationService : INavigationService
    {
        private readonly NavigationManager _navManager;

        public NavigationService(NavigationManager navManager)
        {
            _navManager = navManager;
        }

        public void UpdateUrlWithName(string basePath, int id, string? name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                string formattedName = Uri.EscapeDataString(name.Replace(" ", "-"));
                _navManager.NavigateTo($"{basePath}/{id}?name={formattedName}", forceLoad: false);
            }
        }
    }
}
