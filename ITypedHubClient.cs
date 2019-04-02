using System.Threading.Tasks;

namespace backend_signalr
{
    public interface ITypedHubClient
    {
         Task BroadcastMessage(string name, string payload);
    }
}