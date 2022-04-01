using Microsoft.AspNetCore.Mvc;

namespace Web_HTTP_Protocol.Controllers
{

    //  /cats/list
    //  /cats/details
    public class CatsController : Controller
    {
        public IActionResult List()
        {

            return View();

            //this.Response.Headers.Add("Content-Disposition", "attachment");
            //return File("/path/to/pdf", "application/pdf");


            //return Redirect("/cats/search");
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
