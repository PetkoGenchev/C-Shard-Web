namespace FootballManager.Controllers
{
    using FootballManager.Data;
    using FootballManager.Data.Models;
    using FootballManager.Services;
    using FootballManager.ViewModels.Players;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System.Linq;

    public class PlayersController : Controller
    {
        private readonly IValidator validator;
        private readonly FootballManagerDbContext data;

        public PlayersController(
                FootballManagerDbContext data,
                IValidator validator)
        {
            this.data = data;
            this.validator = validator;
        }


        public HttpResponse Add() => View();

        [HttpPost]
        public HttpResponse Add(AddPlayerFormModel model)
        {
            var modelError = this.validator.ValidatePlayer(model);

            if (modelError.Any())
            {
                return Error(modelError);
            }

            var registerPlayer = new Player
            {
                FullName = model.FullName,
                ImageUrl = model.ImageUrl,
                Position = model.Position,
                Speed = model.Speed,
                Endurance = model.Endurance,
                Description = model.Description
            };

            this.data.Players.Add(registerPlayer);
            this.data.SaveChanges();


            return Redirect("/Players/All");
        }

        [Authorize]
        public HttpResponse All()
        {
            var playersQuery = this.data.Players.AsQueryable();

            var players = playersQuery
                .Select(c => new PlayersListingViewModel
                {
                    Id = c.Id,
                    Image = c.ImageUrl,
                    Endurance = c.Endurance,
                    Speed = c.Speed,
                    Name = c.FullName,
                    Position = c.Position,
                    Description = c.Description
                })
                .ToList();

            return View(players);
        }


    }
}
