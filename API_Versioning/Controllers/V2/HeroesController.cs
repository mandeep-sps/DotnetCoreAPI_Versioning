using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Versioning.Controllers.V2
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class HeroesController : ControllerBase
    {

        [MapToApiVersion("2.0")]
        [HttpGet, Route("alive")]
        public string Alive()
        {
            return "Hi There, 2.0 Here. I'm Alive and Kicking!";
        }
    }
}
