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

        public void AddTask(TaskEntry task)
        {
            _context.Add(task);
            _context.SaveChanges();
        }
    }
}
