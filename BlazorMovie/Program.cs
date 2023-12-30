using BlazorMovie.Components;
using BlazorMovie.Models;
using BlazorMovie.Models.Interfaces;
using BlazorMovie.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<TMDBClient>();
builder.Services.AddScoped<IMovieService<PopularMovie>, PopularMovieService>();
builder.Services.AddScoped<IMovieService<NowPlaying>, NowPlayingService>();
builder.Services.AddScoped<IMovieService<TopRated>, TopRatedService>();
builder.Services.AddScoped<IMovieService<Upcoming>, UpcomingComingSoonService>();


await builder.Build().RunAsync();
