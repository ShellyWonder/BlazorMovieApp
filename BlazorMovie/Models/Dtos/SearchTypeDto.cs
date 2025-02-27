namespace BlazorMovie.Models.Dtos
{
    public class SearchTypeDto
    {
        public string Movie { get; set; } = string.Empty;
        public string Person { get; set; } = string.Empty;

        //implementing Genre search in next feature update
        public string Genre { get; set; } = string.Empty;
    }
}
