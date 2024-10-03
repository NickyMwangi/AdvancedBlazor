using Microsoft.JSInterop;

namespace Web.Helpers
{
    public static class IJSRuntimeExtensions
    {
        public static async Task ShowToastr(this IJSRuntime jsRuntime, string toastrType, string message)
        {
            await jsRuntime.InvokeVoidAsync("showToastr", toastrType, message);
        }
    }
}
