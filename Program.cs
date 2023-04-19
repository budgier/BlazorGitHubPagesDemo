using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorGitHubPagesDemo;
using Microsoft.JSInterop;
using System.Security.AccessControl;
using ll;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.RootComponents.Add<ll.MyUpdatingComponent>("#counter"); // add the updating component with the CSS selector "#updating-component"


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(ss => new MyUpdatingComponent());

var host = builder.Build();

// Start the updating component
var updatingComponent = host.Services.GetRequiredService<ll.MyUpdatingComponent>();
updatingComponent.StartUpdating();

await host.RunAsync();