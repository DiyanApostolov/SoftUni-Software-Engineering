namespace BattleCards.Controllers
{
    using BattleCards.Data;
    using BattleCards.Data.Models;
    using BattleCards.Models;
    using BattleCards.Services;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System.Linq;

    public class CardsController : Controller
    {
        private readonly Validator validator;
        private readonly BattleCardsDbContext data;

        public CardsController(Validator validator, BattleCardsDbContext data)
        {
            this.validator = validator;
            this.data = data;
        }
        
        [Authorize]
        public HttpResponse All()
        {
            return View();
        }

        [Authorize]
        public HttpResponse Add() => this.View();

        [HttpPost]
        [Authorize]
        public HttpResponse Add(CardFormModel model)
        {
            var errors = this.validator.ValidateCard(model);

            if (errors.Any())
            {
                return Error(errors);
            }

            var user = this.data.Users
                .First(u => u.Id == this.User.Id);

            var card = new Card
            {
                Name = model.Name,
                ImageUrl = model.Image,
                Keyword = model.Keyword,
                Description = model.Description,
                Attack = model.Attack,
                Health = model.Health
            };

            this.data.Cards.Add(card);
            this.data.SaveChanges();

            this.data.UserCards.Add(new UserCard
            { 
                Id = user.Id,
                CardId = card.Id
            });

            this.data.SaveChanges();

            return Redirect("/Cards/All");
        }

        [Authorize]
        public HttpResponse Collection()
        {
            var collection = this.data.UserCards
                .Where(uc => uc.Id == this.User.Id)
                .Select(c => c.Card)
                .Select(c => new CardListingModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Keyword = c.Keyword,
                    Description = c.Description,
                    Attack = c.Attack,
                    Health = c.Health,
                    ImageUrl = c.ImageUrl
                }).ToList();

            return this.View(collection);
        }

    }
}
