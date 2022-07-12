namespace Git.Controllers
{
    using Git.Data;
    using Git.Data.Models;
    using Git.Models.Commits;
    using Git.Services;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System.Linq;

    using static Data.DataConstants;

    public class CommitsController : Controller
    {
        private readonly IValidator validator;
        private readonly GitDbContext data;

        public CommitsController(
                GitDbContext data,
                IValidator validator)
        {
            this.data = data;
            this.validator = validator;
        }


        [Authorize]
        public HttpResponse Create(string id)
        {
            var repository = this.data
                .Repositories
                .Where(x => x.Id == id)
                .Select(r => new CommitToRepositoryViewModel
                {
                    Id = r.Id,
                    Name = r.Name
                })
                .FirstOrDefault();

            if (repository == null)
            {
                return BadRequest();
            }

            return View(repository);
        }

        [HttpPost]
        [Authorize]
        public HttpResponse Create(CreateCommitViewModel model)
        {

            if(! this.data.Repositories.Any(r => r.Id == model.Id))
            {
                return NotFound();
            }

            if (model.Description.Length < UserNDescrMinLength)
            {
                return Error($"Commit description must be at least {UserNDescrMinLength} symbols.");
            }

            var commit = new Commit
            {
                Description = model.Description,
                RepositoryId = model.Id,
                CreatorId = this.User.Id,
                
                
            };


            this.data.Commits.Add(commit);
            this.data.SaveChanges();

            return Redirect("/Repositories/All");
        }


        [Authorize]
        public HttpResponse All()
        {
            var commitsQuery = this.data.Commits.AsQueryable();

            var commits = commitsQuery
                .Where(x => x.CreatorId == this.User.Id)
                .Select(c => new CommitsListingViewModel
                {
                    Id=c.Id,
                    RepositoryName = c.Repository.Name,
                    CreatedOn = c.CreatedOn,
                    Description = c.Description
                })
                .ToList();

            return View(commits);
        }



        [Authorize]
        public HttpResponse Delete(string id)
        {
            var commitToRemove = this.data
                .Commits
                .Find(id);

            if (commitToRemove == null || commitToRemove.CreatorId != this.User.Id)
            {
                return BadRequest();
            }

            this.data.Commits.Remove(commitToRemove);

            this.data.SaveChanges();

            return Redirect("/Commits/All");
        }


    }
}
