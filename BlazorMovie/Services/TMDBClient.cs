using BlazorMovie.Models;
using System.Net.Http.Json;


namespace BlazorMovie.Services
{
    public class TMDBClient
    {
        private readonly HttpClient _httpClient;

        public TMDBClient(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;
            
            _httpClient.BaseAddress = new Uri("https://api.themoviedb.org/3/");
            _httpClient.DefaultRequestHeaders.Accept.Add(new( "application/json"));

            string apiKey = config["TMDBKey"] ?? throw new Exception("TMDBKey not found.");
            _httpClient.DefaultRequestHeaders.Authorization= new("Bearer", apiKey);
        }

       public Task<PopularMoviesPageResponse?> GetPopularMoviesAsync()
        {
            return _httpClient.GetFromJsonAsync<PopularMoviesPageResponse>("movie/popular");
        }
    }
}
