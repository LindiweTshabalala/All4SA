using All4SA.CRUD;
using All4SA.Models;
using Microsoft.AspNetCore.Mvc;

namespace All4SA.Controllers
{
    [ApiController]
    [Route("ImagesReferences")]
    public class ImagesReferencesController : Controller
    {
        [HttpGet(Name = "GetAllImagesReferences")]
        public IActionResult GetAllImagesReferences()
        {
            return new ObjectResult("");
        }

        [HttpGet("GetImageReferenceByID/{imageReferenceID}", Name = "GetImageReferenceByID")]
        public IActionResult GetImageReferenceByID(int imageReferenceID)
        {
            return new ObjectResult("");
        }

        [HttpGet("GetImageReferenceByLink/{link}", Name = "GetImageReferenceByLink")]
        public IActionResult GetImageReferenceByLink(string link)
        {
            return new ObjectResult(ImagesReferencesCRUD.GetByLink(link));
        }

        [HttpPost("AddImageReference", Name = "AddImageReference")]
        public IActionResult AddImageReference(ImageReference imageReference)
        {
            return new ObjectResult("");
        }

        [HttpPut("UpdateImageReference/{imageReferenceID}", Name = "UpdateImageReference")]
        public IActionResult UpdateImageReference(ImageReference imageReference)
        {
            return new ObjectResult("");
        }

        [HttpPut("SoftDeleteImageReference/{imageReferenceID}", Name = "SoftDeleteImageReference")]
        public IActionResult SoftDeleteImageReference(int imageReferenceID)
        {
            return new ObjectResult("");
        }

        [HttpDelete("DeleteImageReference/{imageReferenceID}", Name = "DeleteImageReference")]
        public IActionResult DeleteImageReference(int imageReferenceID)
        {
            return new ObjectResult("");
        }
    }
}
