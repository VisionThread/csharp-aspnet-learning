using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace app2_exception.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        [HttpGet("")]
        public async Task<IActionResult> GetALL()
        {
            //throw new Exception("Test Exception");
            
            return Ok(new[] { 10, 20, 30, 40 });
        }
    }
}
