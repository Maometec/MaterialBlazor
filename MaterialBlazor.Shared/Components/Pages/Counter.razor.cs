using Microsoft.AspNetCore.Components;

namespace MaterialBlazor.Shared.Components.Pages;

[Route("/counter")]
public partial class Counter
{
    [CascadingParameter]
    public string? Brand { get; set; }

    [CascadingParameter]
    public EventCallback<string> OnLoaded { get; set; }

    private string title = "Counter";
    private int currentCount = 0;

    protected override async Task OnInitializedAsync()
    {
        await OnLoaded.InvokeAsync(title);
    }

    private void IncrementCount()
    {
        currentCount++;
    }
}
