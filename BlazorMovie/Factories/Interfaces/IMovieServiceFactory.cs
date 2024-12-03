using BlazorMovie.Services.Interfaces;

namespace BlazorMovie.Factories.Interfaces
{
    public interface IMovieServiceFactory
    {
        IBaseMovieService GetService(string category);
    }
}
