using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components;


namespace ll
{
    public class MyUpdatingComponent : ComponentBase, IDisposable
    {
        private System.Timers.Timer _timer;

        public void StartUpdating()
        {
            // Start a timer that will update the component every second
            _timer = new System.Timers.Timer(1000);
            _timer.Elapsed += (sender, args) => InvokeAsync(StateHasChanged);
            _timer.Start();
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            // Build the UI for the component
            builder.OpenElement(0, "div");
            builder.AddContent(1, $"This component updates every second! {DateTime.Now}");
            builder.CloseElement();
           
        }
    }
}