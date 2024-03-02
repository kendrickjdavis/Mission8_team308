namespace Mission_8.Models
{
    public interface ITaskRepository
    {
        List<TaskModel> Tasks { get; }
        List<Category> Categories { get; }
        List<Quadrant> Quadrants { get; }

    }
}
