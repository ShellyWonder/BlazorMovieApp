using BlazorMovie.Factories.Interfaces;
using BlazorMovie.Services;
using BlazorMovie.Services.Interfaces;

namespace BlazorMovie.Factories
{
    public class MovieServiceFactory : IMovieServiceFactory
    {
        private readonly PopularMovieService _popularMovieService;
        private readonly NowPlayingMovieService _nowPlayingMovieService;
        private readonly TopRatedService _topRatedService;
        private readonly UpcomingComingSoonService _upcomingService;
        private readonly ISearchMovieService _searchMovieService;

        public MovieServiceFactory(PopularMovieService popularMovieService,
                                   NowPlayingMovieService nowPlayingMovieService,
                                   TopRatedService topRatedService,
                                   UpcomingComingSoonService upcomingService,
                                   ISearchMovieService searchMovieService)
        {
            _popularMovieService = popularMovieService;
            _nowPlayingMovieService = nowPlayingMovieService;
            _topRatedService = topRatedService;
            _upcomingService = upcomingService;
            _searchMovieService = searchMovieService;

            //Console.WriteLine("MovieServiceFactory initialized with:");
            //Console.WriteLine($"PopularMovieService: {_popularMovieService.GetType().Name}");
            //Console.WriteLine($"NowPlayingMovieService: {_nowPlayingMovieService.GetType().Name}");
            //Console.WriteLine($"TopRatedService: {_topRatedService.GetType().Name}");
            //Console.WriteLine($"UpcomingComingSoonService: {_upcomingService.GetType().Name}");
            //Console.WriteLine($"SearchMovieService: {_searchMovieService.GetType().Name}");
        }

        public IBaseMovieService GetService(string category)
        {
            Console.WriteLine($"From the factory: Resolving service for category: {category}");
            return category switch
            {
                "now_playing" => _nowPlayingMovieService,
                "top_rated"=> _topRatedService,
                "upcoming" => _upcomingService,
                "search_result" => _searchMovieService,
                _ => _popularMovieService
            };
            
        }
    }
}
