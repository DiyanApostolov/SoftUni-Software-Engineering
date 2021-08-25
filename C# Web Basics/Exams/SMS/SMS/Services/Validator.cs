namespace SMS.Services
{
    using SMS.Models.Products;
    using SMS.Models.Users;
    using SMS.Services.Contracts;
    using System.Collections.Generic;
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

        public ICollection<string> ValidateProduct(ProductListingModel model)
        {
            var errors = new List<string>();

            if (model.Name.Length < ProductMinName || model.Name.Length > DefaultMaxLength)
            {
                errors.Add($"Product name should be between {ProductMinName} and {DefaultMaxLength} symbols!");
            }

            if (model.Price < 0.05M || model.Price > 1000)
            {
                errors.Add($"Product price should be between 0.05 and 1000!");
            }

            return errors;
        }
    }
}
