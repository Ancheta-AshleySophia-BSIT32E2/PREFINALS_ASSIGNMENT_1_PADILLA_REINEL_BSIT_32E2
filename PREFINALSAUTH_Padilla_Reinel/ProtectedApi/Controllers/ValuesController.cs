using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProtectedApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            
            var userInfo = new
            {
                Name = "Reinel Padilla",
                Section = "32E2",
                Course = "BSIT"
            };

            var funFacts = new[]
            {
                "I hate coding",
                "I enjoy playing video games",
                "I love dancing",
            };

            return Ok(new { UserInfo = userInfo, FunFacts = funFacts });
        }
    }
}
