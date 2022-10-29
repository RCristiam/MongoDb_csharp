using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MongoDB_csharp.Interfaces;

namespace MongoDB_csharp.ConsoleApp;

internal class Bootstrap
{
    public static IHost CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
        .ConfigureServices((builder) =>
        {
            builder.AddTransient<IOutputDevice, OutputDevice>();
        }).Build();
}