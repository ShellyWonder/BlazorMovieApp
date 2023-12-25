using BlazorMovie.Components;
using BlazorMovie.Models.Interfaces;
using BlazorMovie.Models;
using BlazorMovie.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<TMDBClient>();
builder.Services.AddScoped<PopularMovie, PopularMovieService>();
builder.Services.AddSingleton<MovieServiceFactory>();
builder.Services.AddSingleton<IMovieService<IMovie>>();

await builder.Build().RunAsync();
