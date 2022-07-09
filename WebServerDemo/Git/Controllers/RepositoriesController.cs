namespace Git.Controllers
{
    using Git.Data;
    using Git.Data.Models;
    using Git.Models.Repositories;
    using Git.Services;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System.Linq;

    public class RepositoriesController : Controller
    {
        private readonly IValidator validator;
        private readonly GitDbContext data;

        public RepositoriesController(
                GitDbContext data,
                IValidator validator)
        {
            this.data = data;
            this.validator = validator;
        }


        [Authorize]
        public HttpResponse Create() => View();


        [HttpPost]
        [Authorize]
        public HttpResponse Create(CreateRepositoryFormModel model)
        {
            var modelError = this.validator.ValidateRepositoryType(model);

            if (modelError.Any())
            {
                return Error(modelError);
            }


            bool isRepositoryPublic;

            if (model.repositoryType == "Public")
            {
                isRepositoryPublic = true;
            }
            else
            {
                isRepositoryPublic = false;
            }

            var repositoryToAdd = new Repository()
            {
                Name = model.name,
                IsPublic = isRepositoryPublic,
                OwnerId = this.User.Id
            };

            data.Repositories.Add(repositoryToAdd);
            data.SaveChanges();

            return Redirect("/Repositories/All");
        }



        public HttpResponse All()
        {
            var repositoriesQuery = this.data.Repositories.AsQueryable().Where(r => r.IsPublic);

            var repositories = repositoriesQuery
                .Select(c => new RepositoriesListingViewModel
                {
                    Name=c.Name,
                    Owner = c.Owner.Username,
                    CreatedOn = c.CreatedOn,
                    Commits = c.Commits.Count()
                })
                .ToList();

            return View(repositories);
        }


    }
}
