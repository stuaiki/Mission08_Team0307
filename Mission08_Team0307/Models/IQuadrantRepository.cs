namespace Mission08_Team0307.Models
{
    public interface IQuadrantRepository
    {
        List<TaskEntry> Tasks { get; }

        public void AddTask(TaskEntry task); // to add a task

        public void UpdateTask(TaskEntry task); // to update a task

        public void DeleteTask(TaskEntry task); // to delete a task
    }
}
