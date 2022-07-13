namespace FootballManager.Controllers
{
    using FootballManager.Data;
    using FootballManager.Data.Models;
    using FootballManager.Services;
    using FootballManager.ViewModels.Users;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System.Linq;

    public class UsersController : Controller
    {
        private readonly IValidator validator;
        private readonly FootballManagerDbContext data;
        private readonly IPasswordHasher passwordHasher;

        public UsersController(
                FootballManagerDbContext data,
                IValidator validator,
                IPasswordHasher passwordHasher)
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

            if (this.data.Users.Any(u => u.Username == model.Username))
            {
                modelError.Add($"Username {model.Username} is already in use.");
            }

            if (this.data.Users.Any(p => p.Email == model.Email))
            {
                modelError.Add($"Email {model.Email} is already in use.");
            }

            if (modelError.Any())
            {
                return Error(modelError);
            }

            var registerUser = new User
            {
                Username = model.Username,
                Email = model.Email,
                Password = this.passwordHasher.HashPassword(model.Password)
            };

            this.data.Users.Add(registerUser);
            this.data.SaveChanges();

            return Redirect("/Users/Login");
        }

        public HttpResponse Login() => View();

        [HttpPost]
        public HttpResponse Login(LoginUserFormModel model)
        {
            var hashedPassword = this.passwordHasher.HashPassword(model.password);

            var returnUser = this.data
                .Users
                .Where(x => x.Username == model.username && x.Password == hashedPassword)
                .Select(i => i.Id)
                .FirstOrDefault();

            if (returnUser == null)
            {
                return Error($"Username and password combination is not valid!");
            }

            this.SignIn(returnUser);


            return Redirect("/Players/All");
        }


        public HttpResponse Logout()
        {
            this.SignOut();

            return Redirect("/");

        }
    }
}
