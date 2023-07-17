using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace ProgramandoConBlazor.Client.Pages
{
    public partial class Counter
    {
        [Inject] ServicioSingleton singleton { get; set; } = null!;
        [Inject] ServicioTransient transient { get; set; } = null!;
        [Inject] protected IJSRuntime js { get; set; } = null!;
        

        IJSObjectReference? modulo;

        private int currentCount = 0;
        private static int currentCountStatic = 0;

        [JSInvokable]
        public async Task IncrementCount()
        {
            //Aplicado aislamiento de JS (solo se cargara Counter.js con este componente)
            modulo = await js.InvokeAsync<IJSObjectReference>("import", "./js/Counter.js");
            await modulo.InvokeVoidAsync("mostrarAlerta", "Hola JS");

            currentCount++;
            currentCountStatic = currentCount;
            singleton.Valor = currentCount;
            transient.Valor = currentCount;

            //Este JS se cargara en todos los componentes
            await js.InvokeVoidAsync("pruebaDotNetStatic");
        }

        private async Task IncrementCountJS()
        {
            await js.InvokeVoidAsync("pruebaDotNetInstancia", DotNetObjectReference.Create(this));
        }

        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}
