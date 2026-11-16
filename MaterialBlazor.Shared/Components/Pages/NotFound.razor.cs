using Microsoft.AspNetCore.Components;

namespace MaterialBlazor.Shared.Components.Pages;

[Route("/not-found")]
public partial class NotFound
{
    [CascadingParameter]
    public string? Brand { get; set; }

    [CascadingParameter]
    public EventCallback<string> OnLoaded { get; set; }

    private string title = "Error!";

    protected override async Task OnInitializedAsync()
    {
        await OnLoaded.InvokeAsync(title);
    }
}
