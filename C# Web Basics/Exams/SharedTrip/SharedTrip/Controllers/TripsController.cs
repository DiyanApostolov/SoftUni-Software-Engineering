namespace SharedTrip.Controllers
{
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using SharedTrip.Data;
    using SharedTrip.Models;
    using SharedTrip.Models.Trips;
    using SharedTrip.Services;
    using System;
    using System.Globalization;
    using System.Linq;

    using static Data.DataConstants;

    public class TripsController : Controller
    {

        private readonly IValidator validator;
        private readonly ApplicationDbContext data;

        public TripsController(IValidator validator, ApplicationDbContext data)
        {
            this.validator = validator;
            this.data = data;
        }

        [Authorize]
        public HttpResponse All()
        {
            var trips = this.data.Trips
                .Select(c => new TripListingModel
                {
                    Id = c.Id,
                    StartPoint = c.StartPoint,
                    EndPoint = c.EndPoint,
                    DepartureTime = c.DepartureTime.ToString(DateFormat),
                    ImagePath = c.ImagePath,
                    Description = c.Description,
                    Seats = c.Seats
                }).ToList();

            return this.View(trips);
        }

        [Authorize]
        public HttpResponse Add() => this.View();

        [Authorize]
        [HttpPost]
        public HttpResponse Add(AddTripFormModel model)
        {
            var errors = this.validator.ValidateTrip(model);

            if (errors.Any())
            {
                return Error(errors);
            }

            var user = this.data.Users
                .First(u => u.Id == this.User.Id);

            var trip = new Trip
            {
                StartPoint = model.StartPoint,
                EndPoint = model.EndPoint,
                DepartureTime = DateTime.ParseExact(model.DepartureTime, DateFormat, CultureInfo.InvariantCulture),
                ImagePath = model.ImagePath,
                Seats = model.Seats,
                Description = model.Description

            };

            this.data.Trips.Add(trip);
            this.data.SaveChanges();

            this.data.UserTrips.Add(new UserTrip
            {
                UserId = user.Id,
                TripId = trip.Id
            });

            this.data.SaveChanges();

            return this.Redirect("/Trips/All");
        }

        [Authorize]
        public HttpResponse Details(string tripId)
        {
            var trip = data.Trips.First(t => t.Id == tripId);

            return this.View(trip);
        }

        [Authorize]
        public HttpResponse AddUserToTrip(string tripId)
        {
            if (this.data.UserTrips.Any(user => user.TripId == tripId && user.UserId == this.User.Id))
            {
                return this.Redirect("/Trips/All");
            }

            var trip = this.data.Trips
                .First(t => t.Id == tripId);

            this.data.UserTrips.Add(new UserTrip
            {
                UserId = this.User.Id,
                TripId = tripId
            });

            this.data.SaveChanges();

            trip.Seats--;

            this.data.SaveChanges();

            return this.Redirect("/Trips/All");
        }
    }
}
