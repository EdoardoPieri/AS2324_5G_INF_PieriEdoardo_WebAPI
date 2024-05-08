using Microsoft.AspNetCore.Mvc;

namespace AS2324_5G_INF_PieriEdoardo_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : Controller
    {
        [HttpGet("PrimoMutliploDelSecondo")]
        public JsonResult PrimoMultiploDelSecondo(int num, int factor)
        {
            if(num % factor == 0)
            {
                return Json(new { status = "OK", result = true});
            } else return Json(new { status = "OK", result = false });
        }
        [HttpGet("Potenza")]
        public JsonResult Potenza(int b, int esponente)
        {
            int res = b;
            for (int c = 1; c < esponente; c++)
            {
                res = res * b;
            }
            return Json(new { status = "OK", result = res });
        }
        [HttpGet("AnnoBisestile")]
        public JsonResult AnnoBisestile(int anno)
        {
            if (anno % 400 == 0 || (anno % 4 == 0 && !(anno % 100 == 0)))
            {
                return Json(new { status = "OK", bisestile = true });
            }
            else
            {
                return Json(new { status = "OK", bisestile = false });
            }
        }
        [HttpGet("CalcoloIpotenusa")]
        public JsonResult CalcoloIpotenusa(double cateto1, double cateto2)
        {
            return Json(new { status = "OK", ipotenusa = Math.Sqrt((cateto1 * cateto1) + (cateto2 * cateto2)) });
        }
    }
}
