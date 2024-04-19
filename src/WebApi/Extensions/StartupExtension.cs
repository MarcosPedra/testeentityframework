namespace WebApi.Extensions
{
    public static class StartupExtension
    {
        public static WebApplicationBuilder UseStartup<TStartup>(this WebApplicationBuilder webAppbuilder) where TStartup : Interfaces.IStartup
        {
            var startup = Activator.CreateInstance(typeof(TStartup), webAppbuilder.Configuration) as Interfaces.IStartup;
            if (startup == null) throw new ArithmeticException("Classe Startup.cs inválida.");

            startup.ConfigureServices(webAppbuilder.Services);
            var app = webAppbuilder.Build();
            startup.Configure(app, app.Environment);

            app.Run();

            return webAppbuilder;
        }
    }
}
