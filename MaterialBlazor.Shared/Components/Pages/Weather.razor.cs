using MaterialBlazor.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace MaterialBlazor.Shared.Components.Pages;

[Route("/weather")]
public partial class Weather
{
    private WeatherForecast[]? forecasts;
    private string title = "Weather";

    [CascadingParameter]
    public string? Brand { get; set; }

    [CascadingParameter]
    public EventCallback<string> OnLoaded { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await OnLoaded.InvokeAsync(title);
        // Simulate asynchronous loading to demonstrate a loading indicator
        await Task.Delay(500);

        var startDate = DateOnly.FromDateTime(DateTime.Now);
        var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
        forecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = startDate.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = summaries[Random.Shared.Next(summaries.Length)]
        }).ToArray();
    }
}
