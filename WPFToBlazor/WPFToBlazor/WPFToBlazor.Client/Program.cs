using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WPFToBlazor.ApiClient;

namespace WPFToBlazor.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddScoped<IApiClient, ApiClient.ApiClient>(sp =>
            {
                var httpClient = sp.GetRequiredService<HttpClient>();
                return new ApiClient.ApiClient(httpClient); 
            });

            await builder.Build().RunAsync();
        }
    }
}
