﻿using System.Text.Json.Serialization;

namespace BlazorMovie.Models.Credits
{
    public class Cast : Person
    {
        [JsonPropertyName("cast_id")]
        public int CastId { get; set; }

        [JsonPropertyName("character")]
        public string Character { get; set; } = string.Empty;

        [JsonPropertyName("order")]
        public int Order { get; set; }
    }

}