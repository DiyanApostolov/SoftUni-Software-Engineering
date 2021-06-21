namespace CarShop.Services
{
    using CarShop.Models.Users;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using static Data.DataConstants;

    public class Validator : IValidator
    {
        public ICollection<string> ValidateUserRegistration(RegisterUserFormModel model)
        {
            var errors = new List<string>();

            if (model.Username.Length < UserMinUsername || model.Username.Length > DefaultMaxLength)
            {
                errors.Add($"Username '{model.Username}' is not valid. It must me between {UserMinPassword} and {DefaultMaxLength} characters long.");
            }

            if (!Regex.IsMatch(model.Email, UserEmailRegularExpression))
            {
                errors.Add($"Email {model.Email} is not a valid e-mail address.");
            }

            if (model.Password.Length < UserMinPassword || model.Password.Length > DefaultMaxLength)
            {
                errors.Add($"The provided password '{model.Password}' is not valid. It must me between {UserMinPassword} and {DefaultMaxLength} characters long.");
            }

            if (model.Password != model.ConfirmPassword)
            {
                errors.Add("Password and its confirmation are differenet.");
            }

            if (model.UserType != UserTypeMechanic && model.UserType != UserTypeClient)
            {
                errors.Add($"User shoud be either a '{UserTypeMechanic}' or '{UserTypeClient}'.");
            }

            return errors;
        }
    }
}
