namespace SMS.Controllers
{
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using SMS.Data;

    public class CartsController : Controller
    {
        private readonly SMSDbContext data;

        public CartsController(SMSDbContext data)
        {
            this.data = data;
        }

        public HttpResponse Details()
        {
            return View();
        }
    }
}
