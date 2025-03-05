namespace BlazorMovie.Models.Interfaces
{
    public interface IPersonMinimal
    {
        public int Id { get;  }
        public string Name { get; }
        public string ProfilePath { get; }
        public float Popularity { get; set; }
    }
}
