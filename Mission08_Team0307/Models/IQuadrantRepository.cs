namespace Mission08_Team0307.Models
{
    public interface IQuadrantRepository
    {
        List<TaskEntry> Tasks { get; }

        public void AddTask(TaskEntry task);

        public void UpdateTask(TaskEntry task);
    }
}
