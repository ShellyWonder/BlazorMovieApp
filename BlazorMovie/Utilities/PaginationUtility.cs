using BlazorMovie.Models;

namespace BlazorMovie.Utilities
{
    public class PaginationUtility
    {
        public static PageResponse<T> PaginateList<T>(IList<T> source, int currentPage, int pageSize)
        {
            ArgumentNullException.ThrowIfNull(source);
            if (currentPage < 1) currentPage = 1;

            int totalCount = source.Count;
            int totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            var paginatedResults = source
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return new PageResponse<T>
            {
                Page = currentPage,
                TotalResults = totalCount,
                TotalPages = totalPages,
                Results = paginatedResults
            };
        }

    }
}
