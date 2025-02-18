using BlazorMovie.Models;

namespace BlazorMovie.Utilities
{
    public class MovieServiceHelperUtility
    {
        
        /// <summary>
        /// Maps a PageResponse of some Movie-derived type (e.g. NowPlaying) to a PageResponse<Movie>.
        /// </summary>
        public static PageResponse<Movie> MapToMoviePageResponse<T>(PageResponse<T> source)
            where T : Movie // T must derive from Movie
        {
            return source == null
                ? throw new ArgumentNullException(nameof(source))
                : new PageResponse<Movie>
                {
                Page = source.Page,
                TotalPages = source.TotalPages,
                TotalResults = source.TotalResults,
                Dates = source.Dates,
                //using collection expression to cast the source.Results to a collection of Movie
                Results = [.. source.Results.Cast<Movie>()]
                };
        }
       
    }
}
