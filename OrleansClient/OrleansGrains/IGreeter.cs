using Orleans;
using System.Threading.Tasks;

public interface IGreeter : IGrainWithStringKey
{
    Task<string> SayHello(string name);
}