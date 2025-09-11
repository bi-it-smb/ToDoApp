namespace ToDoApp.Data
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string Status { get; set; } // "pending", "in_progress", "completed"
    }
}
