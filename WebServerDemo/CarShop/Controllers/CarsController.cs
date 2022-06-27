namespace CarShop.Controllers
{
    using CarShop.Data;
    using CarShop.Data.Models;
    using CarShop.Models.Cars;
    using CarShop.Services;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System.Linq;

    public class CarsController : Controller
    {
        private readonly IValidator validator;


        public CarsController(IValidator validator)
        {
            this.validator = validator;
        }


        public HttpResponse Add() => View();

        [HttpPost]
        public HttpResponse Add(AddCarFormModel model)
        {
            var modelerrors = this.validator.ValidateCar(model);


            if (modelerrors.Any())
            {
                return Error(modelerrors);
            }

            var car = new Car
            {

            }

        }   


        public HttpResponse All()
        {

        }
    }
}
