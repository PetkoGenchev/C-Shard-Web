namespace CarShop.Controllers
{
    using CarShop.Data;
    using CarShop.Data.Models;
    using CarShop.Models.Cars;
    using CarShop.Services;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System.Collections.Generic;
    using System.Linq;

    public class CarsController : Controller
    {
        private readonly IValidator validator;
        private readonly CarShopDbContext data;
        private readonly IUserService userService;

        public CarsController(IValidator validator, CarShopDbContext data, IUserService userService)
        {
            this.validator = validator;
            this.data = data;
            this.userService = userService;
        }

        [Authorize]
        public HttpResponse Add()
        {

            if (this.userService.IsMechanic(this.User.Id))
            {
                return Unauthorized();
            }

            return View();
        }


        [HttpPost]
        [Authorize]
        public HttpResponse Add(AddCarFormModel model)
        {
            var modelerrors = this.validator.ValidateCar(model);


            if (modelerrors.Any())
            {
                return Error(modelerrors);
            }

            var car = new Car
            {
                Model = model.Model,
                Year = model.Year,
                PictureUrl = model.Image,
                PlateNumber = model.PlateNumber,
                OwnerId = this.User.Id
            };

            this.data.Cars.Add(car);
            this.data.SaveChanges();

            return Redirect("/Cars/All");

        }

        [Authorize]
        public HttpResponse All()
        {
            var carsQuery = this.data.Cars.AsQueryable();


            if (this.userService.IsMechanic(this.User.Id))
            {
                carsQuery = carsQuery.Where(x => x.Issues.Any(i => !i.IsFixed));
            }
            else
            {
                carsQuery = carsQuery.Where(c => c.OwnerId == this.User.Id);
            }

            var cars = carsQuery
                .Select(c => new CarListingViewModel
                {
                Id = c.Id,
                Model = c.Model,
                Year = c.Year,
                PlateNumber = c.PlateNumber,
                Image = c.PictureUrl,
                FixedIssues = c.Issues.Where(f => f.IsFixed).Count(),
                RemainingIssues = c.Issues.Where(r => !r.IsFixed).Count()
                })
                .ToList();

            return View(cars);
        }

    }
}
