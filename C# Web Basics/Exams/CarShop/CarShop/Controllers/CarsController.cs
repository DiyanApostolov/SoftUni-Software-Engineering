namespace CarShop.Controllers
{
    using CarShop.Data;
    using CarShop.Data.Models;
    using CarShop.Models.Cars;
    using CarShop.Services;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System.Linq;

    public class CarsController : Controller
    {
        private readonly CarShopDbContext data;
        private readonly IValidator validator;

        public CarsController(CarShopDbContext data, IValidator validator)
        {
            this.data = data;
            this.validator = validator;
        }

        [Authorize]
        public HttpResponse All()
        {
            return View();
        }

        [Authorize]
        public HttpResponse Add()
        {
            var userIsMechanic = data
                .Users
                .Any(u => u.Id == this.User.Id && u.IsMechanic);

            if (userIsMechanic)
            {
                return Error("Mechanics cannot add cars.");
            }

            return View();
        }

        [Authorize]
        [HttpPost]
        public HttpResponse Add(AddCarFormModel model)
        {
            var modelErrors = this.validator.ValidateCar(model);


            if (modelErrors.Any())
            {
                return Error(modelErrors);
            }

            var car = new Car
            {
                Model = model.Model,
                Year = model.Year,
                PictureUrl = model.Image,
                PlateNumber = model.PlateNumber,
                OwnerId = this.User.Id
            };

            data.Cars.Add(car);

            data.SaveChanges();

            return Redirect("/Cars/All");
        }
    }
}
