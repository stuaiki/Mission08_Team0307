namespace Mission08_Team0307.Models
{
    public class EFQuadrantRepository : IQuadrantRepository
    {
        private QuadrantContext _context;
        public EFQuadrantRepository(QuadrantContext quadrant)
        {
            _context = quadrant;
        }

        public List<TaskEntry> Tasks => _context.Tasks.ToList();

        public IQueryable<Category> Categories => _context.Categories;

        public void AddTask(TaskEntry task) // method that can be called by _repo to add a task
        {
            _context.Add(task);
            _context.SaveChanges();
        }

        public void DeleteTask(TaskEntry task) // method that can be called by _repo to delete a task
        {
            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }

        public void UpdateTask(TaskEntry task) // method that can be called by _repo to update task
        {
            _context.Update(task);
            _context.SaveChanges();
        }
    }
}
