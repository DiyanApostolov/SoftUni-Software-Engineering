namespace BattleCards.Controllers
{
    using BattleCards.Data;
    using BattleCards.Data.Models;
    using BattleCards.Models.Cards;
    using BattleCards.Services;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System.Linq;

    public class CardsController : Controller
    {
        private readonly Validator validator;
        private readonly ApplicationDbContext data;

        public CardsController(Validator validator, ApplicationDbContext data)
        {
            this.validator = validator;
            this.data = data;
        }

        [Authorize]
        public HttpResponse All()
        {
            var cards = this.data.Cards
                .Select(c => new CardListingModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    ImageUrl = c.ImageUrl,
                    Attack = c.Attack,
                    Health = c.Health,
                    Description = c.Description,
                    Keyword = c.Keyword
                }).ToList();

            return this.View(cards);
        }

        [Authorize]
        public HttpResponse Add() => View();

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
                UserId = user.Id,
                CardId = card.Id
            });

            this.data.SaveChanges();

            return Redirect("/Cards/All");
        }

        [Authorize]
        public HttpResponse Collection()
        {
            var collection = this.data.UserCards
                .Where(uc => uc.UserId == this.User.Id)
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

        [Authorize]
        public HttpResponse AddToCollection(int cardId)
        {
            if (this.data.UserCards.Any(user => user.CardId == cardId && user.UserId == this.User.Id))
            {
                return this.Redirect("/Cards/All");
            }

            this.data.UserCards.Add(new UserCard
            {
                UserId = this.User.Id,
                CardId = cardId
            });

            this.data.SaveChanges();

            return this.Redirect("/Cards/All");
        }

        [Authorize]
        public HttpResponse RemoveFromCollection(int cardId)
        {
            var userCard = this.data.UserCards
                .First(uc => uc.UserId == this.User.Id && uc.CardId == cardId);

            this.data.UserCards.Remove(userCard);

            this.data.SaveChanges();

            return this.Redirect("/Cards/Collection");
        }
    }
}
