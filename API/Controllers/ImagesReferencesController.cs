using All4SA.CRUD;
using All4SA.Models;
using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    [ApiController]
    [Route("ImagesReferences")]
    public class ImagesReferencesController : Controller
    {
        [HttpGet("GetImageReferenceByLink/{link}", Name = "GetImageReferenceByLink")]
        public IActionResult GetImageReferenceByLink(string link)
        {
            return new ObjectResult(ImagesReferencesCRUD.GetByLink(link));
        }

        [HttpPost("AddImageReference", Name = "AddImageReference")]
        public IActionResult AddImageReference(ImageReference imageReference)
        {
            return new ObjectResult(ImagesReferencesCRUD.InsertEntry(imageReference));
        }
    }
}
