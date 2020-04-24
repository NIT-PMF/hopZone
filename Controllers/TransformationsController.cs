using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HopZoneV2.Controllers
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
