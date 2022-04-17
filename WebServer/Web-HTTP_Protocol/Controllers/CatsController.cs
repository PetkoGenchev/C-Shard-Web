using Microsoft.AspNetCore.Mvc;

namespace Web_HTTP_Protocol.Controllers
{

    //  /cats/list
    //  /cats/details
    public class CatsController : Controller
    {
        public IActionResult List()
        {
            var requestCookies = this.Request.Cookies;

            if (!requestCookies.ContainsKey("Authentication"))
            {
                return Unauthorized();
            }

            return View();

        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }
    }
}
