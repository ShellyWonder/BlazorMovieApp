using BlazorMovie.Models;
using BlazorMovie.Models.Interfaces;
using System;

namespace BlazorMovie.Services
{
    public class MovieServiceFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public MovieServiceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public IMovieService<TMovie> GetMovieService<TMovie>() where TMovie : IMovie
        {
           
            if (typeof(TMovie) == typeof(NowPlaying))
            {
                return (IMovieService<TMovie>)_serviceProvider.GetService(typeof(NowPlayingService))!;
            }
            else if (typeof(TMovie) == typeof(PopularMovie))
            {
                return (IMovieService<TMovie>)_serviceProvider.GetService(typeof(PopularMovieService))!;
            }
            else if (typeof(TMovie) == typeof(Result))
            {
                return (IMovieService<TMovie>)_serviceProvider.GetService(typeof(TopRatedService))!;
            }
            else if (typeof(TMovie) == typeof(Upcoming))
            {
                return (IMovieService<TMovie>)_serviceProvider.GetService(typeof(UpcomingComingSoonService))!;
            }
            else
            {
                throw new ArgumentException($"No service available for type '{typeof(TMovie).Name}'.");
            }

            
        }
        
    }
}
