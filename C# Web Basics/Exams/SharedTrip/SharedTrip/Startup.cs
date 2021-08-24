namespace SharedTrip
{
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;

    using MyWebServer;
    using MyWebServer.Controllers;
    using MyWebServer.Results.Views;
    using SharedTrip.Data;
    using SharedTrip.Services;

    public class Startup
    {
        public static async Task Main()
            => await HttpServer
                .WithRoutes(routes => routes
                    .MapStaticFiles()
                    .MapControllers())
                .WithServices(services => services
                    .Add<IValidator, Validator>()
                    .Add<IPasswordHasher, PasswordHasher>()
                    .Add<IViewEngine, CompilationViewEngine>()
                    .Add<ApplicationDbContext>())
                .WithConfiguration<ApplicationDbContext>(context => context
                    .Database.Migrate())
                .Start();
    }
}
