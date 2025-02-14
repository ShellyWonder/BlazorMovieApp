namespace BlazorMovie.Services.Interfaces
{
    public interface INavigationService
    {
        void UpdateUrlWithName(string basePath, int id, string? name);
    }
}
