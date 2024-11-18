using Orleans;
using System.Threading.Tasks;

public class GreeterGrain : Grain, IGreeter
{
    public Task<string> SayHello(string name)
    {
        return Task.FromResult($"Hello, {name}! Welcome to Orleans");
    }
}