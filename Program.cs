using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorGitHubPagesDemo;
using Microsoft.JSInterop;
using System.Security.AccessControl;




var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSingleton(ps => new Pokerstars.Class1());
  
ArgumentNullException.ThrowIfNull(args, "args");

//builder.RootComponents.Add<ll.MyUpdatingComponent>("updating-element"); // add the updating component with the CSS selector "#updating-component"

//builder.Services.Add<Pokerstars.Class1>(new Pokerstars.Class1());



builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//builder.Services.AddScoped(ss => new MyUpdatingComponent());

var host = builder.Build(); // Build the host

// Start the updating component
//var updatingComponent = host.Services.GetRequiredService<ll.MyUpdatingComponent>();
 

await host.RunAsync();