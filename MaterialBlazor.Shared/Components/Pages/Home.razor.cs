using Microsoft.AspNetCore.Components;

namespace MaterialBlazor.Shared.Components.Pages;

[Route("/")]
public partial class Home
{
    [CascadingParameter]
    public string? Brand { get; set; }

    [CascadingParameter]
    public EventCallback<string> OnLoaded { get; set; }

    private string title = "Home";

    protected override async Task OnInitializedAsync()
    {
        await OnLoaded.InvokeAsync(title);
    }
}
