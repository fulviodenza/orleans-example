using Microsoft.Extensions.Hosting;
using Orleans.Hosting;

Host.CreateDefaultBuilder(args)
.UseOrleans(builder =>
{
    builder.UseLocalhostClustering();
}).Build().Run();