using BlazorMovie.Services.Interfaces;

namespace BlazorMovie.Factories.Interfaces
{
    public interface IMovieServiceFactory
    {
        IMovieService GetService(string category);
    }
}
