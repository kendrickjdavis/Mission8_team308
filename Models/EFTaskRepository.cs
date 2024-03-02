
using SQLitePCL;

namespace Mission_8.Models
{
    public class EFTaskRepository : ITaskRepository
    {
        private QuandrantContext _context;
        public EFTaskRepository(QuandrantContext temp) 
        {
            _context = temp;
        }

        public List<TaskModel> Tasks => _context.Tasks.ToList();

        public void AddTask(TaskModel task)
        {
            _context.Add(task);
            _context.SaveChanges();

        }

        public void RemoveTask(int ID) 
        {
            var recordToDelete = _context.Tasks.Single(x => x.TaskId == ID);
            _context.Tasks.Remove(recordToDelete);
            _context.SaveChanges(); 
        }
    }
}
