using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Api.Controllers
{
    [ApiController]
    [Route("api/Project")]
    public class ProjectController : BaseController<Project>
    {
            [HttpGet]
            public IActionResult GetAllProjects()
            {
            return base.Get();
            }

            [HttpGet]
            [Route("{projectId}")]
            public IActionResult GetProject(long projectId)
            {
            return base.Get(projectId);
            }

            [HttpPut]
            public IActionResult UpdateProject([FromBody] Project projectDetail)
            {
            return Put();
            }

            [HttpPost]
            public IActionResult CreateUser([FromBody] Project projectDetail)
            {
            return Post();
            }
        }
}
