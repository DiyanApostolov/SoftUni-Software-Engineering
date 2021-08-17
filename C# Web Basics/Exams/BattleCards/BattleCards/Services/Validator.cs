namespace BattleCards.Services
{
    using BattleCards.Models.Cards;
    using BattleCards.Models.Users;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    using static Data.DataConstants;

    public class Validator : IValidator
    {
        public ICollection<string> ValidateUser(RegisterFormModel model)
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

        public ICollection<string> ValidateCard(CardFormModel model)
        {
            var errors = new List<string>();

            if (model.Name.Length < MinCardName || model.Name.Length > MaxCardName)
            {
                errors.Add($"Name '{model.Name}' is not valid. Should be at least {MinCardName} symbols and maximum {MaxCardName} symbols.");
            }

            if (!Uri.IsWellFormedUriString(model.Image, UriKind.Absolute))
            {
                errors.Add("Invalid url address.");
            }

            if (model.Description.Length > MaxCardDescription)
            {
                errors.Add($"Description cannot be more than {MaxCardDescription} symbols.");
            }

            if (model.Attack < AttackAndHealthMinValue)
            {
                errors.Add("Attack cannot be a negative number!");
            }

            if (model.Health < AttackAndHealthMinValue)
            {
                errors.Add("Health cannot be a negative number!");
            }

            return errors;

        }
    }
}
