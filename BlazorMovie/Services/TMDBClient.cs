﻿using BlazorMovie.Models;
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
            _httpClient.DefaultRequestHeaders.Accept.Add(new("application/json"));

            string apiKey = config["TMDBKey"] ?? throw new Exception("TMDBKey not found.");
            _httpClient.DefaultRequestHeaders.Authorization = new("Bearer", apiKey);
        }
        #region PopularMovies 
        public Task<PopularMoviesPageResponse?> GetPopularMoviesAsync(int page = 1)
        {
            page = MovieCount(page);

            return _httpClient.GetFromJsonAsync<PopularMoviesPageResponse>($"movie/popular?page={page}");
        }


        public Task<MovieDetails?> GetMovieDetailsAsync(int id)
        {
            return _httpClient.GetFromJsonAsync<MovieDetails>($"movie/{id}");
        }
        #endregion

        #region NowPlaying 
        public Task<NowPlayingPageResponse?> GetNowPlayingAsync(int page = 1)
        {
            page = MovieCount(page);

            return _httpClient.GetFromJsonAsync<NowPlayingPageResponse>($"movie/now_playing?page={page}");
        }

        #endregion

        #region TopRated
        public Task<PageResponse<TopRated>?> GetTopRatedAsync(int page = 1)
        {
            page = MovieCount(page);

            return _httpClient.GetFromJsonAsync<PageResponse<TopRated>>($"movie/top_rated?page={page}");
        }
        #endregion

        #region Upcoming
        public Task<PageResponse<Upcoming>?> GetUpcomingAsync(int page = 1)
        {
            page = MovieCount(page);

            return _httpClient.GetFromJsonAsync<PageResponse<Upcoming>>($"movie/upcoming?page={page}");
        }
        #endregion

        private static int MovieCount(int page)
        {
            if (page < 1) page = 1;
            if (page > 500) page = 500;
            return page;
        }
    }
}
