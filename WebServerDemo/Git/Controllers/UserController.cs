namespace Git.Controllers
{
    using Git.Data;
    using Git.Data.Models;
    using Git.Models.Users;
    using Git.Services;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System.Linq;

    public class UserController : Controller
    {
        private readonly IValidator validator;
        private readonly GitDbContext data;
        private readonly IPasswordHasher passwordHasher;

        public UserController(GitDbContext data, IValidator validator, IPasswordHasher passwordHasher)
        {
            this.data = data;
            this.validator = validator;
            this.passwordHasher = passwordHasher;
        }


        public HttpResponse Register() => View();


        [HttpPost]
        public HttpResponse Register(RegisterUserFormModel model)
        {
            var modelError = this.validator.ValidateUser(model);

            if (this.data.Users.Any(u => u.Username == model.UserName))
            {
                modelError.Add($"Username {model.UserName} is already in use.");
            }

            if (this.data.Users.Any(p => p.Email == model.Email))
            {
                modelError.Add($"Email {model.Email} is already in use.");
            }

            if (modelError.Any())
            {
                return Error(modelError);
            }

            var registeredUser = new User
            {
                Username = model.UserName,
                Email = model.Email,
                Password = this.passwordHasher.HashPassword(model.Password)
            };

            this.data.Users.Add(registeredUser);
            this.data.SaveChanges();

            return Redirect("/Users/Login");

        }


    }
}
