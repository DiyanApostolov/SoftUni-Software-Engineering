namespace BattleCards.Controllers
{
    using BattleCards.Data;
    using BattleCards.Services;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System.Linq;

    public class CardsController : Controller
    {
        private readonly IValidator validator;
        private readonly BattleCardsDbContext data;

        public CardsController(IValidator validator, BattleCardsDbContext data)
        {
            this.validator = validator;
            this.data = data;
        }
        

        public HttpResponse All()
        {
            return View(this.data.Cards.ToList());
        }

        [Authorize]
        public HttpResponse Add()
        { 
            
        }
    }
}
