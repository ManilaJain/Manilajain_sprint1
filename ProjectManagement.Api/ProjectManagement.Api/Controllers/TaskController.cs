using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Entities;
using System.Collections.Generic;

namespace ProjectManagement.Api.Controllers
{
    [ApiController]
    [Route("api/Task")]
    public class TaskController : BaseController<Task>
    {
            [HttpGet]
            public IActionResult GetAllTasks()
            {
            return Get();
            }

            [HttpGet]
            [Route("{taskId}")]
            public IActionResult GetTask(long taskId)
            {
            return Get(taskId);
            }

            [HttpPut]
            public IActionResult UpdateTask([FromBody] Task taskDetail)
            {
            return base.Put();
            }

            [HttpPost]
            public IActionResult CreateTask([FromBody] Task taskDetail)
            {
            return base.Post();
            }
     }
}
