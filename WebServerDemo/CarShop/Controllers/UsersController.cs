namespace CarShop.Controllers
{
    using CarShop.Data;
    using CarShop.Data.Models;
    using CarShop.Models.Users;
    using CarShop.Services;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System.Linq;

    using static Data.DataConstants;

    public class UsersController : Controller
    {
        private readonly IValidator validator;
        private readonly IPasswordHasher passwordHasher;
        private readonly CarShopDbContext data;

        public UsersController(IValidator validator,IPasswordHasher password, CarShopDbContext data)
        {
            this.validator = validator;
            this.data = data;
            this.passwordHasher = password;

        }

        public HttpResponse Register() => View();

        [HttpPost]
        public HttpResponse Register(RegisterUserFormModel model)
        {
            var modelerrors = this.validator.ValidateUser(model);

            if (this.data.Users.Any(u => u.Username == model.Username))
            {
                modelerrors.Add($"Username {model.Username} already in use!");
            }

            if (this.data.Users.Any(u => u.Email == model.Email))
            {
                modelerrors.Add($"Email {model.Email} already in use!");
            }

            if (modelerrors.Any())
            {
                return Error(modelerrors);
            }

            var user = new User
            {
                Username = model.Username,
                Password = this.passwordHasher.HashPassword(model.Password),
                Email = model.Email,
                IsMechanic = model.UserType == Mechanic

            };

            data.Users.Add(user);
            data.SaveChanges();


            return Redirect("/Users/Login");
        }


        public HttpResponse Login() => View();


        [HttpPost]
        public HttpResponse Login(LoginUserFormModel model)
        {
            var hashedPassword = this.passwordHasher.HashPassword(model.Password);

            var userId = this.data
                .Users
                .Where(u => u.Username == model.Username && u.Password == hashedPassword)
                .Select(u => u.Id)
                .FirstOrDefault();

            if (userId == null)
            {
                return Error($"Username and password combination is not valid!");
            }

            this.SignIn(userId);

            return Redirect("/Cars/All");
        }


        public HttpResponse Logout()
        {
            this.SignOut();

            return Redirect("/");
        }
    }
}
