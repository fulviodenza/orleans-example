using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Orleans;

var host = Host.CreateDefaultBuilder(args)
.UseOrleansClient(client =>
{
    client.UseLocalhostClustering();
}).Build();

await host.StartAsync();

var client = host.Services.GetRequiredService<IClusterClient>();

var greeter = client.GetGrain<IGreeter>("MyGrain");
var response = await greeter.SayHello("Orleans User");
Console.WriteLine(response);

await host.StopAsync();