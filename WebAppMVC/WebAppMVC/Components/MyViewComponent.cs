using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;
using WebAppMVC.Services;

namespace WebAppMVC.Components
{
    [ViewComponent(Name = "CustomComponent")]
    public class MyViewComponent : ViewComponent
    {
        private ICustomViewData customViewData;

        public MyViewComponent(ICustomViewData customViewData) 
            => this.customViewData = customViewData;


        public IViewComponentResult Invoke(string name)
        {
            var data = customViewData.GetViewData();

            var model = new CatViewModel
            {
                Name = data
        };

            this.ViewBag.FromViewComponent = $"Some Value + {name}";

            return View();
        }
    }
}
