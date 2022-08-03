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
            var cats = new List<CatViewModel>
            {
                new CatViewModel {Name = "Sharo", Age = 5 },
                new CatViewModel {Name = "Lady", Age = 12 }
            };

            return View(cats);
            
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(CatViewModel model) => Ok(model);

    }
}
