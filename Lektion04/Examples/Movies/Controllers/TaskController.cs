using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Movies.models;
using Movies.services;

namespace Movies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly TaskService _taskService = new TaskService();

        [HttpGet]
        public ActionResult<IEnumerable<TaskItem>> Get()
        {
            return Ok(_taskService.Tasks);
        }

        [HttpGet("{id}")]
        public ActionResult<TaskItem> Get(int id)
        {
            var task = _taskService.Tasks.FirstOrDefault(t => t.Id == id);
            if (task == null) return NotFound();
            return Ok(task);
        }

        [HttpPost]
        public ActionResult<TaskItem> Post([FromBody] CreateTaskDtos dto)
        {
            var task = _taskService.Create(dto);
            return CreatedAtAction(nameof(Get), new { id = task.Id }, task);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateTaskDtos dto)
        {
            var task = _taskService.Tasks.FirstOrDefault(t => t.Id == id);
            if (task == null) return NotFound();

            task.Title = dto.Title;
            task.Description = dto.Description;
            task.IsCompleted = dto.IsCompleted;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var task = _taskService.Tasks.FirstOrDefault(t => t.Id == id);
            if (task == null) return NotFound();
            
            _taskService.Tasks.Remove(task);
            return NoContent();
        }
    }
}