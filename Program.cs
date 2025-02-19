using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorGitHubPagesDemo;
using Microsoft.JSInterop;
using System.Security.AccessControl;
using Microsoft.Extensions.Logging.Console;




var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

  
//builder.RootComponents.Add<ll.MyUpdatingComponent>("updating-element"); // add the updating component with the CSS selector "#updating-component"

//builder.Services.Add<Pokerstars.Class1>(new Pokerstars.Class1());



//	
builder.Services.AddScoped(sp => new HttpClient());
//builder.Logging.AddProvider(new ConsoleLoggerProvider(builder);
var host = builder.Build(); // Build the host
var pass = builder.Configuration["ke"];

// Start the updating component
//var updatingComponent = host.Services.GetRequiredService<ll.MyUpdatingComponent>();
await host.RunAsync();