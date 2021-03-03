using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Entities;
using System.Collections.Generic;

namespace ProjectManagement.Api.Controllers
{
    [ApiController]
    [Route("api/User")]
    public class UserController : BaseController<User>
    {

        [HttpGet]
        public IActionResult Get()
        {
            return base.Get();
        }

        [HttpGet]
        [Route("{userId}")]
        public IActionResult Get(long userId)
        {
            return base.Get(userId);
        }

        [HttpPut]
        public IActionResult UpdateUser([FromBody] User userDetail)
        {
            return Put();
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] User userDetail)
        {
            return Post();
        }

    }
}
