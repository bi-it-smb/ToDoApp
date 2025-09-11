using System.Data;
using Dapper;
using ToDoApp.Data;

namespace ToDoApp.Repositories
{
    public class TaskRepository
    {
        private readonly IDbConnection _db;

        public TaskRepository(IDbConnection db)
        {
            _db = db;
        }

        public async Task<IEnumerable<TaskItem>> GetTasksAsync()
        {
            var sql = "SELECT * FROM Tasks";
            return await _db.QueryAsync<TaskItem>(sql);
        }

        public async Task<TaskItem?> GetTaskByIdAsync(int id)
        {
            var sql = "SELECT * FROM Tasks WHERE Id = @Id";
            return await _db.QueryFirstOrDefaultAsync<TaskItem>(sql, new { Id = id });
        }

        public async Task AddTaskAsync(TaskItem task)
        {
            var sql = "INSERT INTO Tasks (Title, Description, Status) VALUES (@Title, @Description, @Status)";
            await _db.ExecuteAsync(sql, task);
        }

        public async Task UpdateTaskAsync(TaskItem task)
        {
            var sql = "UPDATE Tasks SET Title=@Title, Description=@Description, Status=@Status WHERE Id=@Id";
            await _db.ExecuteAsync(sql, task);
        }

        public async Task DeleteTaskAsync(int id)
        {
            var sql = "DELETE FROM Tasks WHERE Id=@Id";
            await _db.ExecuteAsync(sql, new { Id = id });
        }
    }
}
