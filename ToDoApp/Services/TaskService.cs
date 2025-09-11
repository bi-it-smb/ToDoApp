using ToDoApp.Data;
using ToDoApp.Repositories;

namespace ToDoApp.Services
{
    public class TaskService
    {
        private readonly TaskRepository _repository;

        public TaskService(TaskRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<TaskItem>> GetTasksAsync() => _repository.GetTasksAsync();
        public Task<TaskItem?> GetTaskByIdAsync(int id) => _repository.GetTaskByIdAsync(id);
        public Task AddTaskAsync(TaskItem task) => _repository.AddTaskAsync(task);
        public Task UpdateTaskAsync(TaskItem task) => _repository.UpdateTaskAsync(task);
        public Task DeleteTaskAsync(int id) => _repository.DeleteTaskAsync(id);
    }
}
