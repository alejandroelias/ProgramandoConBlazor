function pruebaDotNetStatic() {
    DotNet.invokeMethodAsync("ProgramandoConBlazor.Client", "GetCurrentCount")
        .then(resultado => {
            console.log('Conteo desde js ' + resultado);
        })
}