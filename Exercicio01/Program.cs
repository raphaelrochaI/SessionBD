using Exercicio01;
using Microsoft.AspNetCore.Hosting;

namespace AcademiaStrongFit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
            //evita a exce��o de banco de dados inexistente
            .UseDefaultServiceProvider(options => options.ValidateScopes = false);
    }
}
