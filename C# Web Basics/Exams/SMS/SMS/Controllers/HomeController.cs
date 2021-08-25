namespace SMS.Controllers
{
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using SMS.Data;
    using SMS.Models.Products;
    using System.Linq;

    public class HomeController : Controller
    {
        private readonly SMSDbContext data;

        public HomeController(SMSDbContext data)
        {
            this.data = data;
        }

        public HttpResponse Index()
        {
            return this.View();
        }

        [Authorize]
        public HttpResponse IndexLoggedIn()
        {
            var products = this.data.Products
                .Select(c => new ProductListingModel
                {
                    Name = c.Name,
                    Price = c.Price
                }).ToList();

            return this.View(products);
        }
    }
}