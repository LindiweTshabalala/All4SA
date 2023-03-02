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
            try
            {
                return new ObjectResult(ImagesReferencesCRUD.GetByLink(link));
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpPost("AddImageReference", Name = "AddImageReference")]
        public IActionResult AddImageReference(ImageReference imageReference)
        {
            try
            {
                return new ObjectResult(ImagesReferencesCRUD.InsertEntry(imageReference));
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
