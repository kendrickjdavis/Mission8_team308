namespace Mission_8.Models
{
    public interface ITaskRepository
    {
        List<TaskModel> Tasks { get; }

        public void AddTask(TaskModel task);

        public void RemoveTask(TaskModel task);
    }
}
