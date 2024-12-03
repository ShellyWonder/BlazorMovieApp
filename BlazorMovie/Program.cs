using BlazorMovie.Components;
using BlazorMovie.Factories;
using BlazorMovie.Factories.Interfaces;
using BlazorMovie.Services;
using BlazorMovie.Services.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<TMDBClient>();


builder.Services.AddTransient<PopularMovieService>();
builder.Services.AddTransient<NowPlayingMovieService>();
builder.Services.AddTransient<TopRatedService>();
builder.Services.AddTransient<UpcomingComingSoonService>();
builder.Services.AddScoped<ISearchMovieService, SearchMovieService>();


builder.Services.AddScoped<MovieCacheService>();
builder.Services.AddScoped<IMovieServiceFactory, MovieServiceFactory>();

await builder.Build().RunAsync();
