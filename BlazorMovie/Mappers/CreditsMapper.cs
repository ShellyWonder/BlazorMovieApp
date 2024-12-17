using BlazorMovie.Models.Credits;

namespace BlazorMovie.Mappers
{
    public class CreditsMapper
    {
     
        #region MAP CAST TO PERSONDETAILS
            public static List<PersonDetails> MapCastToDetails(Cast[] castArray)
            {
                return castArray.Select(c => new PersonDetails
                {
                    Id = c.Id,
                    Name = c.Name,
                    ProfilePath = c.ProfilePath,
                    KnownForDepartment = c.KnownForDepartment,
                    Popularity = c.Popularity,
                    AKA = null, // Initialize as empty or populate when API data exists
                    Biography = string.Empty,
                    Birthdate = null,
                    Deathdate = null,
                    Birthplace = string.Empty,
                    Homepage = string.Empty,
                    ImdbId = string.Empty,
                }).ToList();
            }
            #endregion

            #region MAP CAST
            public static List<Cast> MapCast(Cast[] castArray)
            {
                return castArray.Select(c => new Cast
                {
                    Id = c.Id,
                    Name = c.Name,
                    ProfilePath = c.ProfilePath,
                    KnownForDepartment = c.KnownForDepartment,
                    CreditId = c.CreditId,
                    Gender = c.Gender,
                    Popularity = c.Popularity,
                    CastId = c.CastId,
                    Character = c.Character,
                    Order = c.Order
                }).ToList();
            }
            #endregion

            #region MAP CREW
            public static List<Crew> MapCrew(Crew[] crewArray)
            {
                return crewArray.Select(c => new Crew
                {
                    Id = c.Id,
                    Name = c.Name,
                    ProfilePath = c.ProfilePath,
                    KnownForDepartment = c.KnownForDepartment,
                    CreditId = c.CreditId,
                    Gender = c.Gender,
                    Popularity = c.Popularity,
                    Department = c.Department,
                    Job = c.Job
                }).ToList();
            }
        #endregion

        // Cast-specific properties
        //Character = c.Character,
        //            CastId = c.CastId,
        //            Order = c.Order

    }

}   

