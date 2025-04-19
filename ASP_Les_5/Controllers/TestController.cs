using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Les_5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [Authorize]
        [HttpGet("private")]
        public IActionResult GetPrivate()
        {
            return Ok(new { Message = "This is a protected endpoint!" });
        }
        [HttpGet("public")]
        public IActionResult GetPublic()
        {
            return Ok(new { Message = "This is a public!" });
        }
    }
}
