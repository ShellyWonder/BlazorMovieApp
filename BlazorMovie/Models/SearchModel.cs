﻿namespace BlazorMovie.Models
{
    public class SearchModel
    {
        public string Category { get; set; } = string.Empty;
        public string SearchTerm { get; set; } = string.Empty;

        public MovieDetails? MovieDetails { get; set; }

    }
}