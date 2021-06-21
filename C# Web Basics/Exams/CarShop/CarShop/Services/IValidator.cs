namespace CarShop.Services
{
    using CarShop.Models.Users;
    using System.Collections.Generic;

    public interface IValidator
    {
        ICollection<string> ValidateUserRegistration(RegisterUserFormModel model);
    }
}
