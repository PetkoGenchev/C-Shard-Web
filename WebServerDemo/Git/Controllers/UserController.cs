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


        public HttpResponse Login() => View();


        [HttpPost]
        public HttpResponse Login(RegisterUserFormModel model)
        {
            var hashedPassword = this.passwordHasher.HashPassword(model.Password);

            var returnUser = this.data
                .Users
                .Where(u => u.Username == model.UserName && u.Password == hashedPassword)
                .Select(i => i.Id)
                .FirstOrDefault();

            if (returnUser != null)
            {
                return Error($"Username and password combination is not valid!");
            }

            this.SignIn(returnUser);

            return Redirect("/Repositories/All");

        }


        public HttpResponse Logout()
        {
            this.SignOut();

            return Redirect("/");
        }
    }
}
