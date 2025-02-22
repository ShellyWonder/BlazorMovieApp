using BlazorMovie.Factories.Interfaces;
using BlazorMovie.Services;
using BlazorMovie.Services.Interfaces;
using BlazorMovie.Services.TMDBMovieListServices;

namespace BlazorMovie.Factories
{
    public class MovieServiceFactory : IMovieServiceFactory
    {
        private readonly PopularMovieService _popularMovieService;
        private readonly NowPlayingMovieService _nowPlayingMovieService;
        private readonly TopRatedService _topRatedService;
        private readonly UpcomingComingSoonService _upcomingService;
        private readonly ISearchService _searchService;

        public MovieServiceFactory(PopularMovieService popularMovieService,
                                   NowPlayingMovieService nowPlayingMovieService,
                                   TopRatedService topRatedService,
                                   UpcomingComingSoonService upcomingService,
                                   ISearchService searchService)
        {
            _popularMovieService = popularMovieService;
            _nowPlayingMovieService = nowPlayingMovieService;
            _topRatedService = topRatedService;
            _upcomingService = upcomingService;
            _searchService = searchService;
  
        }

        public IBaseMovieService GetService(string category)
        {
            Console.WriteLine($"From the factory: Resolving service for category: {category}");
            return category switch
            {
                "now_playing" => _nowPlayingMovieService,
                "top_rated"=> _topRatedService,
                "upcoming" => _upcomingService,
                "search_result" => _searchService,
                _ => _popularMovieService
            };
            
        }
    }
}
