using TaskWebApp.Api.Models;
using TaskWebApp.Api.Repositories;

    namespace TaskWebApp.Api.Services
    {
        public class TaskService
        {
            private readonly ITaskRepository _repo;

            public TaskService(ITaskRepository repo)
            {
                _repo = repo;
            }

            public TaskItem Create(TaskItem task)
            {
            task.Status = TaskWebApp.Api.Models.TaskStatus.ToDo;
            _repo.Add(task);
                return task;
            }

            public List<TaskItem> GetAll() => _repo.GetAll();
        }
    }
