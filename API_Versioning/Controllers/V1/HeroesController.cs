using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace API_Versioning.Controllers.V1
{
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("0.9", Deprecated = true)]
    [Route("api/v{version:apiVersion}/[controller]")]
    //[Route("api/[controller]")]
    public class HeroesController : ControllerBase
    {

       
        [Produces("application/json")]
        [HttpGet, Route("alive")]
        public string Alive()
        {
            return "Hi There, 1.0 Here. I'm Alive and Kicking!";
        }

        [Produces("application/json")]
        [HttpGet, Route("Get")]
        [MapToApiVersion("1.0")]
        public string Get()
        {
            return "Hello World!";
        }
    }
}
