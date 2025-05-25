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
    }
}
