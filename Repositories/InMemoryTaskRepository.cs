using TaskWebApp.Api.Models;
namespace TaskWebApp.Api.Repositories
{
    public class InMemoryTaskRepository : ITaskRepository
    {
        private static readonly List<TaskItem> _tasks = new();

        public void Add(TaskItem task)
        {
            _tasks.Add(task);
        }

        public List<TaskItem> GetAll()
        {
            return _tasks;
        }
    }
}