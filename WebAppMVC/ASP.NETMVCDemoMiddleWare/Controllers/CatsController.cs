using ASP.NETMVCDemoMiddleWare.Filters;
using ASP.NETMVCDemoMiddleWare.Models;
using ASP.NETMVCDemoMiddleWare.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ASP.NETMVCDemoMiddleWare.Controllers
{
    public class CatsController : Controller
    {
        private readonly ICatService catService;

        public CatsController(ICatService catService)
        {
            this.catService = catService;
        }

        [AddHeader(Name = "My-Header", Value = "My-Header-Value")]
        public IActionResult All()
        {
            return View(new CatViewModel { Name = "Sharo" });
        }
    }
}
