// See https://aka.ms/new-console-template for more information

using EasySave.App;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<MainWorker>();
    });

IHost host = hostBuilder.Build();

host.RunAsync();