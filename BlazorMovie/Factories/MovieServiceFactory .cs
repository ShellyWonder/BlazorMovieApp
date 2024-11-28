using BlazorMovie.Factories.Interfaces;
using BlazorMovie.Models;
using BlazorMovie.Models.Interfaces;
using BlazorMovie.Services.Interfaces;

namespace BlazorMovie.Factories
{
    public class MovieServiceFactory : IMovieServiceFactory
    {
        private readonly IMovieService<NowPlaying> _nowPlayingService;
        private readonly IMovieService<PopularMovie> _popularMovieService;
        private readonly IMovieService<TopRated> _topRatedService;
        private readonly IMovieService<Upcoming> _upcomingService;

        public MovieServiceFactory(IMovieService<NowPlaying> nowPlayingService, 
                                   IMovieService<PopularMovie> popularMovieService, 
                                   IMovieService<TopRated> topRatedService,
                                   IMovieService<Upcoming> upcomingService)
        {
            _nowPlayingService = nowPlayingService;
            _popularMovieService = popularMovieService;
            _topRatedService = topRatedService;
            _upcomingService = upcomingService; 
        }

        public IMovieService<IMovie> GetService(string category)
        {
            return category switch
            {
                "now_playing" => (IMovieService<IMovie>)_nowPlayingService,
                "upcoming" => (IMovieService<IMovie>)_upcomingService,
                "top_rated"=> (IMovieService<IMovie>)_topRatedService,
                _ => (IMovieService<IMovie>)_popularMovieService
            };
        }
    }
}
