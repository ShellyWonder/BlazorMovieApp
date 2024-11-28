using BlazorMovie.Models.Interfaces;
using BlazorMovie.Services.Interfaces;

namespace BlazorMovie.Factories.Interfaces
{
    public interface IMovieServiceFactory
    {
        IMovieService<IMovie> GetService(string category);
    }
}
