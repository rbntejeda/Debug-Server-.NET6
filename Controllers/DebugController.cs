using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Debug.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DebugController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public ActionResult GetAll()
        {
            return Ok();
        }
    }
}
