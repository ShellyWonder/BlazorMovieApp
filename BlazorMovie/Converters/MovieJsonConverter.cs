using BlazorMovie.Models;
using BlazorMovie.Models.Interfaces;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlazorMovie.Converters
{
    public class MovieJsonConverter : JsonConverter<IMovie>
    {
        public override IMovie Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
            {
                var root = doc.RootElement;

                // Check the "type" property to determine the category
                if (root.TryGetProperty("type", out var typeProperty))
                {
                    var movieType = typeProperty.GetString();

                    // Match the type to the appropriate concrete class
                    return movieType switch
                    {
                        "popular" => JsonSerializer.Deserialize<PopularMovie>(root.GetRawText(), options),
                        "top_rated" => JsonSerializer.Deserialize<TopRated>(root.GetRawText(), options),
                        "now_playing" => JsonSerializer.Deserialize<NowPlaying>(root.GetRawText(), options),
                        "upcoming" => JsonSerializer.Deserialize<Upcoming>(root.GetRawText(), options),
                        _ => throw new JsonException($"Unknown movie type: {movieType}")
                    };
                }

                throw new JsonException("Movie type property is missing.");
            }
        }

        public override void Write(Utf8JsonWriter writer, IMovie value, JsonSerializerOptions options)
        {
            // Serialize the concrete type of IMovie
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }

}
