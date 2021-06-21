namespace BattleCards.Services
{
    using System.Collections.Generic;
    using BattleCards.Models.Users;

    public interface IValidator
    {
        ICollection<string> ValidateUser(RegisterUserFormModel model);

    }
}
