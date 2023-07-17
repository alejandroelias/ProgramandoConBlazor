using Microsoft.JSInterop;

namespace ProgramandoConBlazor.Client.Helpers
{
    public  static class IJSRuntimeExtensionmethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message) => await js.InvokeAsync<bool>("confirm", message);
    }
}
