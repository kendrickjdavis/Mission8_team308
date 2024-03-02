
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
        public List<Category> Categories => _context.Categories.ToList();
        public List<Quadrant> Quadrants => _context.Quadrants.ToList();
    }
}
