using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace ProgramandoConBlazor.Client.Pages
{
    public partial class Counter
    {
        [Inject] ServicioSingleton singleton { get; set; } = null!;
        [Inject] ServicioTransient transient { get; set; } = null!;
        [Inject] IJSRuntime js { get; set; } = null!;

        private int currentCount = 0;
        private static int currentCountStatic = 0;

        private async Task IncrementCount()
        {
            currentCount++;
            currentCountStatic = currentCount;
            singleton.Valor = currentCount;
            transient.Valor = currentCount;
            await js.InvokeVoidAsync("pruebaDotNetStatic");
        }

        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}
