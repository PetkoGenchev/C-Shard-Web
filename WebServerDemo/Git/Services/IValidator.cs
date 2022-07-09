namespace Git.Services
{
    using Git.Models.Repositories;
    using Git.Models.Users;
    using System.Collections.Generic;


    public interface IValidator
    {
        public ICollection<string> ValidateUser(RegisterUserFormModel model);
        public ICollection<string> ValidateRepositoryType(CreateRepositoryFormModel model);
    }
}