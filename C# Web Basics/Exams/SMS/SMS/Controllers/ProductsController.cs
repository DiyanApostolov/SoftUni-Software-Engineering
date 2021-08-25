namespace SMS.Controllers
{
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using SMS.Data;
    using SMS.Models;
    using SMS.Models.Products;
    using SMS.Services.Contracts;
    using System.Linq;

    public class ProductsController : Controller
    {
        private readonly IValidator validator;
        private readonly SMSDbContext data;

        public ProductsController(IValidator validator, SMSDbContext data)
        {
            this.validator = validator;
            this.data = data;
        }

        

        [Authorize]
        public HttpResponse Create() => this.View();

        [Authorize]
        [HttpPost]
        public HttpResponse Create(ProductListingModel model)
        {
            var errors = this.validator.ValidateProduct(model);

            if (errors.Any())
            {
                return Error(errors);
            }

            var user = this.data.Users
                .First(u => u.Id == this.User.Id);

            var product = new Product
            {
                Name = model.Name,
                Price = model.Price

            };

            this.data.Products.Add(product);
            this.data.SaveChanges();

            return this.Redirect("/Home/IndexLoggedIn");
        }

        [Authorize]
        public HttpResponse Add(string productId)
        {
            var product = data.Products
                .First(p => p.Id == productId);

            var cart = data.Carts.First(u => u.Id == this.User.Id);

            cart.Products.Add(product);

            this.data.Carts.Add(cart);

            this.data.SaveChanges();

            return this.Redirect("/Carts/Details");
        }
    }
}
