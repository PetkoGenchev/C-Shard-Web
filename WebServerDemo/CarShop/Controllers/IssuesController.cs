namespace CarShop.Controllers
{
    using CarShop.Data;
    using CarShop.Data.Models;
    using CarShop.Models.Issues;
    using CarShop.Services;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System.Linq;

    public class IssuesController : Controller
    {
        private readonly CarShopDbContext data;
        private readonly IUserService userService;
        private readonly IValidator validator;

        public IssuesController(IValidator validator, CarShopDbContext data, IUserService userService)
        {
            this.data = data;
            this.userService = userService;
            this.validator = validator;
        }

        [Authorize]
        public HttpResponse CarIssues(string carId)
        {
            if (!this.userService.IsMechanic(this.User.Id))
            {
                var userOwnsCar = this.data.Cars
                    .Any(c => c.Id == carId && c.OwnerId == this.User.Id);

                if (!userOwnsCar)
                {
                    return Error("You do not have access to this car");
                }
            }

            var carWithIssues = this.data.Cars
                .Where(c => c.Id == carId)
                .Select(c => new CarIssuesViewModel
                {
                    Id = c.Id,
                    Model = c.Model,
                    Year = c.Year,
                    Issues = c.Issues.Select(i => new IssueListingViewModel
                    {
                        Id = i.Id,
                        Description = i.Description,
                        IsFixed = i.IsFixed
                    })
                })
                .FirstOrDefault();

            if (carWithIssues == null)
            {
                return Error($"Car with with ID {carId} does not exist!");
            }

            return View(carWithIssues);

        }

        [Authorize]
        public HttpResponse Add(string carId) => View(new AddIssueViewModel { CarId = carId });


        [HttpPost]
        [Authorize]
        public HttpResponse Add(AddIssueFormModel model)
        {

            if (!this.UserCanAccessCar(model.CarId))
            {
                return Unauthorized();
            }


            var modelErrors = this.validator.ValidateIssue(model);


            if (modelErrors.Any())
            {
                return Error(modelErrors);
            }


            var issue = new Issue
            {
                Description = model.Description,
                CarId = model.CarId
            };

            this.data.Issues.Add(issue);
            this.data.SaveChanges();

            return Redirect($"/Issues/CarIssues?carId={model.CarId}");

        }

        [Authorize]
        public HttpResponse Fix(string issueId, string carId)
        {
            if (!this.userService.IsMechanic(this.User.Id))
            {
                return Unauthorized();
            }

            var issue = this.data
                .Issues
                .Where(x => x.CarId == carId && x.Id == issueId)
                .FirstOrDefault();

            if (issue == null)
            {
                return Error($"Car with with ID {carId} and Issue with ID {issueId} does not exist!");
            }

            issue.IsFixed = true;

            this.data.SaveChanges();

            return Redirect($"/Issues/CarIssues?carId={carId}");
        }


        [Authorize]
        public HttpResponse Delete(string issueId, string carId)
        {
            if (!this.UserCanAccessCar(carId))
            {
                return Unauthorized();
            }


            var issue = this.data
                .Issues
                .Where(x => x.CarId == carId && x.Id == issueId)
                .FirstOrDefault();

            if (issue == null)
            {
                return Error($"Car with with ID {carId} and Issue with ID{issueId} does not exist!");
            }

            this.data.Remove(issue);

            this.data.SaveChanges();

            return Redirect($"/Issues/CarIssues?carId={carId}");
        }


        private bool UserCanAccessCar(string carId)
        {
            var userIsMechanic = this.userService.IsMechanic(this.User.Id);

            if (!userIsMechanic)
            {
                var userOwnsCar = this.userService.OwnsCar(this.User.Id, carId);

                if (!userOwnsCar)
                {
                    return false;
                }

            }

            return true;
        }
    }
}
