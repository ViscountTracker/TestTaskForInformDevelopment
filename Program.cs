using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TestTaskForInformDevelopment.Data;
//using Microsoft.EntityFrameworkCore.SqlServer;//TODO: ADD THIS IN NuGet Pack
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;//TODO: ADD THIS IN NuGet Pack

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
