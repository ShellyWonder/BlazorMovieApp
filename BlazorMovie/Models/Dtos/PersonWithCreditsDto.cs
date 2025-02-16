using BlazorMovie.Models.Credits;
namespace BlazorMovie.Models.Dtos
{

    public class PersonWithCreditsDto
    {
        public PersonDetails PersonDetails { get; set; } = new PersonDetails();
        public PageResponse<MovieWithCharacter> MovieCredits { get; set; } = new PageResponse<MovieWithCharacter>();
    }
}
