using BlazorMovie.Models.Credits;
namespace BlazorMovie.Models.Dtos
{

    public class PersonWithCreditsDto
    {
        public PersonDetails PersonDetails { get; set; } = new PersonDetails();
        public PageResponse<MovieCastDto> MovieCredits { get; set; } = new PageResponse<MovieCastDto>();
    }
}
