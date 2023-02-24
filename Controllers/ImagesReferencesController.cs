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

        [HttpPost("AddImageReference", Name = "AddImageReference")]
        public IActionResult AddImageReference(string ImageReference)
        {
            return new ObjectResult("");
        }

        [HttpPut("UpdateImageReference/{imageReferenceID}", Name = "UpdateImageReference")]
        public IActionResult UpdateImageReference(int imageReferenceID, string ImageReference)
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
