namespace TaskExecutor.Models
{
    public enum TaskStatus
    {
        Pending = 0,
        MarkTrue = 1,
        MarkFalse = 2
    }

    public class Task
    {
        public Task()
        {
            Status = TaskStatus.Pending;
            TaskName = $"Task - {System.DateTime.Now.ToLongDateString()}";
        }

        public string TaskName { get; set; }

        public TaskStatus Status { get; set; }
    }
}
