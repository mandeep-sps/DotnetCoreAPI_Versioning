using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace API_Versioning.Controllers.V3
{
    [ApiController]
    [ApiVersion("3.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    //[Route("api/[controller]")]
    public class HeroesController : ControllerBase
    {

        [MapToApiVersion("3.0")]
        [HttpGet, Route("alive")]
        public string Alive()
        {
            return "Hi There, 3.0 Here. I'm Alive and Kicking!";
        }
    }
}
