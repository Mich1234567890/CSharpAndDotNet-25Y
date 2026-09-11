using Movies.models;

namespace Movies.services
{
    public class TaskService
    {
        public List<TaskItem> Tasks { get; set; } = new();
        private int _nextId = 1;

        public TaskItem Create(CreateTaskDtos dto)
        {
            var task = new TaskItem()
            {
                Id = _nextId++,
                Title = dto.Title,
                Description = dto.Description,
                IsCompleted = false,
                CreatedAt =  DateTime.Now,
            };
            Tasks.Add(task);
            return task;
        }
    }
}