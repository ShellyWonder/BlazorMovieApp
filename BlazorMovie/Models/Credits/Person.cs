﻿using BlazorMovie.Models.Interfaces;
using System.Text.Json.Serialization;

namespace BlazorMovie.Models.Credits
{
    public class Person : IPersonMinimal
    {
        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        [JsonPropertyName("gender")]
        public int Gender { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("known_for_department")]
        public string KnownForDepartment { get; set; } = string.Empty;  

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("original_name")]
        public string OriginalName { get; set; } = string.Empty;

        [JsonPropertyName("popularity")]
        public float Popularity { get; set; }

        [JsonPropertyName("profile_path")]
        public string ProfilePath { get; set; } = string.Empty;

        [JsonPropertyName("credit_id")]
        public string CreditId { get; set; } = string.Empty;
    }
}
