using Microsoft.Extensions.Hosting;

namespace EasySave.App;

public class MainWorker : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        Console.WriteLine("Hello World");
    }
}