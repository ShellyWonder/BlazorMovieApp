using BlazorMovie.Models.Credits;

namespace BlazorMovie.Services.Interfaces
{
    public interface IPersonService
    {
        Task<PersonDetails> GetPersonDetails(int id);
    }
}
