using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    // /Cats/All
    public class CatsController : Controller
    {
        public IActionResult All()
        {
            var cats = new List<string>
            {
                "Sharo",
                "Lady"
            };

            return View(cats);
            
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(CatFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return Ok();
        }

    }
}
