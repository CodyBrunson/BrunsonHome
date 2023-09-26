using System.Net.Http.Json;
using BrunsonHome.Shared.Entities;
using Microsoft.AspNetCore.Components;

namespace BrunsonHome.Client.Pages;

public partial class Horses
{
    [Inject] HttpClient Http { get; set; }
    
    private List<Horse>? horses;

    protected override async Task OnInitializedAsync()
    {
        var result = await Http.GetFromJsonAsync<List<Horse>>("api/Horse/GetAllHorses");
        if (result is not null)
        {
            horses = result;
        }
    }
}