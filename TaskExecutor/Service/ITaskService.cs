namespace TaskExecutor.Service
{
    public interface ITaskService
    {
        Task TaskPick();
        void TaskAdd(Task task);
        List<Task> GetAll();
        void TaskStatusUpdate(Task task);
    }
}
