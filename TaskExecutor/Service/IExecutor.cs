using System.Xml.Linq;
using TaskExecutor.Models;

namespace TaskExecutor.Service
{
    public interface IExecutor
    {
        void ExecuteTask(NodeRegistrationRequest node);
        void ExecuteTask(Models.Task task);
    }
}
