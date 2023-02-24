using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    [ApiController]
    [Route("ImagesReferences")]
    public class ImagesReferencesController : Controller
    {
        [HttpGet(Name = "GetAllImagesReferences")]
        public IActionResult Index()
        {
            return new ObjectResult("");
        }
    }
}
