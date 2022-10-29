using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MongoDB_csharp.Interfaces;

namespace MongoDB_csharp.ConsoleApp;

internal class Runner{

    private IHost _builder;

    public Runner(string[] args){
        _builder = Bootstrap.CreateHostBuilder(args);
    }

    public void Run(){

        IServiceProvider serviceProvider = _builder.Services;
        IOutputDevice asdf = serviceProvider.GetService<IOutputDevice>();
        asdf.Write("### Coming from Runner: It works");

    }

}