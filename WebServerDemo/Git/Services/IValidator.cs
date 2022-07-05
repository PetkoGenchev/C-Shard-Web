namespace Git.Services
{
    using Git.Models.Users;
    using System.Collections.Generic;


    public interface IValidator
    {
        public ICollection<string> ValidateUser(RegisterUserFormModel model);
    }
}
