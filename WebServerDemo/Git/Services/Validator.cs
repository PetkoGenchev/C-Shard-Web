namespace Git.Services
{
    using Git.Models.Users;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
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


            if (!Regex.IsMatch(model.Email, UserEmailRegex))
            {
                errors.Add($"Email is not in the correct format!");
            }


            if (model.Password.Length < 6 || model.Password.Length > UserNPassMaxLength)
            {
                errors.Add($"Password must be between 6 and {UserNPassMaxLength} symbols.");
            }


            if (model.Password != model.ConfirmPassword)
            {
                errors.Add($"Password and Confirm Password do no match.");
            }


            return errors;
        }
    }
}