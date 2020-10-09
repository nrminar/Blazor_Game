using Blazor.Learner.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Blazor.Learner.Client.Pages
{
    public class FetchForecastData : ComponentBase
    {
        public WeatherForecast[] forecasts;
        
        [Inject]
        private HttpClient Http { get; set; }

        protected override async Task OnInitializedAsync()
        {
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("/api/weatherforecast");
        }
    }
}
