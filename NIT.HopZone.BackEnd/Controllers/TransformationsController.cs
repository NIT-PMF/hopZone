using Microsoft.AspNetCore.Mvc;

namespace NIT.HopZone.Web.Controllers
{
    [Route("transform")]
    public class TransformationsController : Controller
    {
        [HttpGet("Fixtures")]
        public ActionResult Fixtures()
        {


            return StatusCode(200, new JsonAdapter().GetPreparedForInsert("head2head.json"));
        }
    }
}
