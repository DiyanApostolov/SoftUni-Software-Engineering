namespace SharedTrip.Services
{
    using SharedTrip.Models.Trips;
    using SharedTrip.Models.Users;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text.RegularExpressions;

    using static Data.DataConstants;

    public class Validator : IValidator
    {
        public ICollection<string> ValidateUser(RegisterUserFormModel model)
        {
            var errors = new List<string>();

            if (model.Username.Length < UserMinUsername || model.Username.Length > DefaultMaxLength)
            {
                errors.Add($"Username '{model.Username}' is not valid. It must be between {UserMinUsername} and {DefaultMaxLength} characters long.");
            }

            if (!Regex.IsMatch(model.Email, UserEmailRegularExpression))
            {
                errors.Add($"Email {model.Email} is not a valid e-mail address.");
            }

            if (model.Password.Length < UserMinPassword || model.Password.Length > DefaultMaxLength)
            {
                errors.Add($"The provided password is not valid. It must be between {UserMinPassword} and {DefaultMaxLength} characters long.");
            }

            if (model.Password.Any(x => x == ' '))
            {
                errors.Add($"The provided password cannot contain whitespaces.");
            }

            if (model.Password != model.ConfirmPassword)
            {
                errors.Add($"Password and its confirmation are different.");
            }

            return errors;
        }

        public ICollection<string> ValidateTrip(AddTripFormModel model)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(model.StartPoint))
            {
                errors.Add($"StartPoint '{model.StartPoint}' can not null or whitespace.");
            }

            if (!DateTime.TryParseExact(model.DepartureTime, DateFormat, null,
                DateTimeStyles.None, out _))
            {
                errors.Add("Invalid date format! Should be 'dd.MM.yyyy HH:mm'");
            }

            if (!Uri.IsWellFormedUriString(model.ImagePath, UriKind.Absolute))
            {
                errors.Add("Invalid URl address.");
            }

            if (model.Description.Length > MaxDescription)
            {
                errors.Add($"Description cannot contain more than {MaxDescription} symbols.");
            }

            if (model.Seats < 2 || model.Seats > 6)
            {
                errors.Add($"Seats should be between {MinSeats} and {MaxSeats}!");
            }

            return errors;
        }
    }
}
