# BlazorMovieApp -Movie Pro Wonder

BlazorMovieApp is a .NET 8 Blazor WebAssembly (WASM) application that integrates with The Movie Database (TMDB) API to provide a user-friendly movie discovery experience. The app showcases popular, top-rated, now playing, and upcoming movies, along with detailed information about movies, cast, crew, and providers.

## Features

- **Popular Movies**: Display the most popular movies.
- **Now Playing**: Show currently playing movies.
- **Top-Rated**: Browse top-rated movies.
- **Upcoming Movies**: Discover movies that are coming soon.
- **Movie Search**: Search for movies by title.
- **Movie Details**: Detailed view of individual movies, including cast, crew, and watch providers.
- **Cast/Crew Details**: View detailed profiles of cast/crew.
- **Caching**: Improves performance with session storage caching for frequently accessed data.

## Technologies Used

- **Framework**: .NET 8 Blazor WASM
- **API**: TMDB API
- **Frontend**: Razor Components, CSS (custom styles)
- **Backend Services**: C# with dependency injection
- **Caching**: JavaScript interop with session storage
- **IDE**: Visual Studio
- **Source Control**: GitHub
- **Responsive Design**: Bootstrap 5.3.3

## Project Structure

### Services

1. **TMDBClient**
   - Core API client for TMDB.
   - Handles all API calls with support for error handling and configurable headers.

2. **PopularMovieService**
   - Retrieves and maps popular movies from TMDB API.

3. **NowPlayingMovieService**
   - Fetches and maps currently playing movies.

4. **TopRatedService**
   - Fetches and maps top-rated movies.

5. **UpcomingComingSoonService**
   - Retrieves upcoming movies.

6. **SearchMovieService**
   - Handles movie search queries with validation for non-empty input.

7. **CreditService**
   - Provides cast/crew details for specific movies.

8. **ProviderService**
   - Retrieves available watch providers for specific movies.

9. **CacheService**
   - Implements session storage for caching API responses to optimize performance.

10. **PersonService**
    - Fetches details of individual cast/crew.
      
### Structural/Programatic Choices

 **Service Level API Implementation**
   -TMDBClient.cs builds the raw API calls
   -Services allow for filters and other logic to be applied to the API calls as desired. 
   -Uniformity is maintained for all calls regardless of complexity
   -Structure facilitates expandability for future filters and database accomodation.
   
 **Session Storage**
 -Eliminates frequent API calls to established categories(found on the nav bar) that may experience multiple clicks. 
 -An expiration time was not set because the stored data is unlikely to change for the session's duration.
 
### Components

1. **MoviePageComponent**
   - Displays paginated lists of movies.

2. **MovieDetailsPage**
   - Detailed view of a movie, including its overview, cast, crew, and providers.

3. **PersonCardComponent**
   - Shows actor profiles with hover effects for more details.

4. **MainCreditComponent**
   - Displays key credits for a movie.

5. **PersonCarouselComponent**
   - Carousel showcasing actors associated with a movie.

### Styles

- **MovieDetailsPage.razor.css**
  - Styling for the detailed movie view.

- **PersonCardComponent.razor.css**
  - Hover effects for actor cards.

## Code Practices

- Utilizes a factory pattern and generics to enhance code reusability.
- Adheres to the Single Responsibility Principle (SRP) and promotes inheritance where applicable.
- Follows the DRY (Don't Repeat Yourself) principle for maintainable and clean code.
- Implements dependency injection for better testability and modularity.

## Setup Instructions

1. **Clone Repository**:
   ```bash
   git clone [repository_url]
   cd BlazorMovieApp
   ```

2. **Configure API Key**:
   - Add your TMDB API key to `appsettings.json` under the key `TMDBKey`.

3. **Run Application**:
   - Open the solution in Visual Studio.
   - Set `BlazorMovieApp` as the startup project.
   - Press `F5` to run the application.

4. **Deploy**:
   - Publish the app to a hosting platform like Azure or GitHub Pages following Blazor WebAssembly deployment guidelines.

## Usage Notes

- Ensure proper attribution when displaying watch providers as per TMDB API guidelines.
- Caching is implemented using session storage for better performance.

## Contributing

1. Fork the repository.
2. Create a new branch for your feature.
3. Commit your changes.
4. Open a pull request.

## License

This project is licensed under the [MIT License](LICENSE).
## Portfolio Status
In Development
---

Enjoy using BlazorMovieApp for your movie discovery needs!

