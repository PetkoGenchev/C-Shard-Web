namespace FootballManager.Services
{
    using FootballManager.ViewModels.Players;
    using FootballManager.ViewModels.Users;
    using System.Collections.Generic;
    public interface IValidator
    {
        public ICollection<string> ValidateUser(RegisterUserFormModel model);

        public ICollection<string> ValidatePlayer(AddPlayerFormModel model);
    }
}
