using BlazorMovie.Models;
using System.Net.Http.Json;
using System.Web;


namespace BlazorMovie.Services
{
    public class TMDBClient
    {
        private readonly HttpClient _httpClient;

#region CONSTRUCTOR
        public TMDBClient(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri("https://api.themoviedb.org/3/");
            _httpClient.DefaultRequestHeaders.Accept.Add(new("application/json"));

            string apiKey = config["TMDBKey"] ?? throw new Exception("TMDBKey not found.");
            _httpClient.DefaultRequestHeaders.Authorization = new("Bearer", apiKey);
        } 
        #endregion

        #region PopularMovies 
        public async Task<PageResponse<PopularMovie>?> GetPopularMoviesAsync(int page = 1)
        {
            page = MovieCount(page);

            var response = await _httpClient.GetFromJsonAsync<PageResponse<PopularMovie>>($"movie/popular?page={page}&language=en-US") ?? throw new Exception("No movie data returned");
            return response;
        }
        #endregion

        #region NowPlaying 
        public async Task<PageResponse<NowPlaying>> GetNowPlayingAsync(int page = 1)
        {
            page = MovieCount(page);

            
                var response = await _httpClient.GetFromJsonAsync<PageResponse<NowPlaying>>($"movie/now_playing?page={page}&language=en-US")
                                                        ?? throw new Exception("No movie data returned");
            return response;
           
        }
        #endregion

        #region TopRated
        public  async Task<PageResponse<TopRated>?> GetTopRatedAsync(int page = 1)
        {
            page = MovieCount(page);

            var response = await _httpClient.GetFromJsonAsync<PageResponse<TopRated>>($"movie/top_rated?page={page}") ?? throw new Exception("No movie data returned"); 
            return response;
        }
        #endregion

        #region Upcoming
        public async Task<PageResponse<Upcoming>?> GetUpcomingAsync(int page = 1)
        {
            page = MovieCount(page);

            var response = await _httpClient.GetFromJsonAsync<PageResponse<Upcoming>>($"movie/upcoming?page={page}") ?? throw new Exception("No movie data returned");
            return response;
        }
        #endregion

        #region MovieDetails
        public Task<MovieDetails?> GetMovieDetailsAsync(int id)
        {
            return _httpClient.GetFromJsonAsync<MovieDetails>($"movie/{id}");
        }
        #endregion

        #region GET Movie Search
        public Task<PageResponse<Movie>?> SearchMoviesByTitle(string title, int page=1)
        {
            page = MovieCount(page);
            // encode the title to make it URL safe
            string encodedTitle = HttpUtility.UrlEncode(title);
            var adult = false;
            var language = "en-US";
            return  _httpClient.GetFromJsonAsync<PageResponse<Movie>?>($"search/movie?query={encodedTitle}&include_adult={adult}&language={language}&page={page}");
        }
        #endregion

        #region Movie Count
        private static int MovieCount(int page)
        {
            if (page < 1) page = 1;
            if (page > 500) page = 500;
            return page;
        } 
        #endregion
    }
}
