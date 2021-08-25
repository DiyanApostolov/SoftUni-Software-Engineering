namespace SMS.Controllers
{
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using SMS.Data;
    using SMS.Models;
    using SMS.Models.Users;
    using SMS.Services.Contracts;
    using System.Linq;

    public class UsersController : Controller
    {
        private readonly IValidator validator;
        private readonly IPasswordHasher passwordHasher;
        private readonly SMSDbContext data;

        public UsersController(IValidator validator, SMSDbContext data, IPasswordHasher passwordHasher)
        {
            this.validator = validator;
            this.passwordHasher = passwordHasher;
            this.data = data;
        }

        public HttpResponse Register()
        {
            return View();
        }

        [HttpPost]
        public HttpResponse Register(RegisterUserFormModel model)
        {
            var modelErrors = this.validator.ValidateUser(model);

            if (this.data.Users.Any(u => u.Username == model.Username))
            {
                modelErrors.Add($"User with '{model.Username}' username already exists.");
            }

            if (this.data.Users.Any(u => u.Email == model.Email))
            {
                modelErrors.Add($"User with '{model.Email}' e-mail already exists.");
            }

            if (modelErrors.Any())
            {
                return Error(modelErrors);
            }

            var user = new User
            {
                Username = model.Username,
                Password = this.passwordHasher.HashPassword(model.Password),
                Email = model.Email,
                Cart = new Cart()
            };

            data.Users.Add(user);

            data.SaveChanges();

            return Redirect("/Users/Login");
        }


        public HttpResponse Login()
        {
            return View();
        }

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
                return Error("Username and password combination is not valid.");
            }

            this.SignIn(userId);

            return Redirect("/Home/IndexLoggedIn");
        }

        

        public HttpResponse Logout()
        {
            this.SignOut();

            return Redirect("/");
        }
    }
}
