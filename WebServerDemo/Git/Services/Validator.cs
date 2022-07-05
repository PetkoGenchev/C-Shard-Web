namespace Git.Services
{
    using Git.Models.Users;
    using System.Collections.Generic;

    using static Data.DataConstants;
    public class Validator : IValidator
    {
        public ICollection<string> ValidateUser(RegisterUserFormModel model)
        {
            var errors = new List<string>();

            if (model.UserName.Length < UserNDescrMinLength || model.UserName.Length > UserNPassMaxLength)
            {
                errors.Add($"Username must be between {UserNDescrMinLength} and {UserNPassMaxLength} symbols.");
            }





            return errors;
        }
    }
}
