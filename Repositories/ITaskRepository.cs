using TaskWebApp.Api.Models;
namespace TaskWebApp.Api.Repositories
{
        public interface ITaskRepository
        {
            void Add(TaskItem task);
            List<TaskItem> GetAll();
        }
    }
