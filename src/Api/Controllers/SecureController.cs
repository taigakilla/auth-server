using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SecureController : ControllerBase
    {
        [HttpGet("private")]
        [Authorize]
        public IActionResult GetPrivateData()
        {
            return Ok(new
            {
                message="Acesso permitido"
            });
        }

        [HttpGet("public")]
        [AllowAnonymous]
        public IActionResult GetPublicData()
        {
            return Ok(new
            {
                message = "acesso publico"
            });
        }
    }
}
