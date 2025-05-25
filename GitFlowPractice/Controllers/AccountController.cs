using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitFlowPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpGet]
        [Route("GetUser")]
        public IActionResult GetUser()
        {
            // Simulate getting user data
            var user = new { Id = 1, Name = "John Doe" };
            if (user == null)
            {
                return NotFound("User not found");
            }
            else
            {
                return Ok(user);
            }
        }

        [HttpGet]
        [Route("GetUserById/{id}")]
        public IActionResult GetUserById(int id)
        {
            // Simulate getting user by ID
            if (id <= 0)
            {
                return BadRequest("Invalid user ID");
            }
            var user = new { Id = id, Name = "John Doe" }; // Simulated user data
            return Ok(user);
        }
    }
}
