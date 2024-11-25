using BlazorMovie.Models.Interfaces;
using System.Text.Json.Serialization;

namespace BlazorMovie.Models
{
    public class NowPlayingPageResponse : PageResponse<NowPlaying>
    {

        [JsonPropertyName("dates")]
        public Dates? Dates { get; set; }


    }




}
