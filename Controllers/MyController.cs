using Microsoft.AspNetCore.Mvc;

namespace wa9test.Controllers
{
    [ApiController]
    public class MyController : Controller
    {
        [HttpGet]
        [Route("/checkHeartBeat")]
        public string PlaceHolder()
        {
            return "Heart is beating";
        }
    }
}
