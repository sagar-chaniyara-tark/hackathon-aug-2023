using System.Xml.Linq;
using TaskExecutor.Models;

namespace TaskExecutor.Service
{
    public interface IWorkerService
    {
        void Register(NodeRegistrationRequest node);
        List<NodeRegistrationRequest> GetAll();
        NodeRegistrationRequest GetCurrentAvailableNode();
    }
}
