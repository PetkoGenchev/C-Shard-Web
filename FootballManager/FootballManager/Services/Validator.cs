namespace FootballManager.Services
{
    using FootballManager.ViewModels.Players;
    using FootballManager.ViewModels.Users;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using static Data.DataConstants;
    public class Validator : IValidator
    {
        public ICollection<string> ValidateUser(RegisterUserFormModel model)
        {
            var errors = new List<string>();

            if (model.Username.Length < DefaultMinLength || model.Username.Length > DefaultMaxLength)
            {
                errors.Add($"Username must be between {DefaultMinLength} and {DefaultMaxLength} symbols.");
            }

            if (model.Email.Length < EmailMinLength || model.Email.Length > EmailMaxLength)
            {
                errors.Add($"Email must be between {EmailMinLength} and {EmailMaxLength} symbols.");
            }

            if (!Regex.IsMatch(model.Email, UserEmailRegex))
            {
                errors.Add($"Email is not in the correct format.");
            }


            if (model.Password.Length < DefaultMinLength || model.Password.Length > DefaultMaxLength)
            {
                errors.Add($"Password must be between {DefaultMinLength} and {DefaultMaxLength} symbols.");
            }

            if (model.Password.Any(x => x == ' '))
            {
                errors.Add($"The provided password cannot cointain whitespaces.");
            }


            if (model.Password != model.ConfirmPassword)
            {
                errors.Add($"Password and Confirm Password do no match.");
            }


            return errors;
        }

        public ICollection<string> ValidatePlayer(AddPlayerFormModel model)
        {
            var errors = new List<string>();

            if (model.FullName.Length < DefaultMinLength || model.FullName.Length > FullNameMaxLength)
            {
                errors.Add($"Username must be between {DefaultMinLength} and {DefaultMaxLength} symbols.");
            }


            if (!Uri.IsWellFormedUriString(model.ImageUrl, UriKind.Absolute))
            {
                errors.Add($"Image {model.ImageUrl} is not a valid URL!");
            }


            if (model.Position.Length < DefaultMinLength || model.Position.Length > DefaultMaxLength)
            {
                errors.Add($"Position must be between {DefaultMinLength} and {DefaultMaxLength}.");
            }


            if (model.Speed < SpeedandEnduranceMinValue || model.Speed > SpeedandEnduranceMaxValue)
            {
                errors.Add($"Speed must be between {SpeedandEnduranceMinValue} and {SpeedandEnduranceMaxValue}.");
            }

            if (model.Endurance < SpeedandEnduranceMinValue || model.Endurance > SpeedandEnduranceMaxValue)
            {
                errors.Add($"Endurance must be between {SpeedandEnduranceMinValue} and {SpeedandEnduranceMaxValue}.");
            }

            if (model.Description.Length > DescriptionMaxLength )
            {
                errors.Add($"Description must be less than {DescriptionMaxLength} symbols.");
            }

            return errors;
        }
    }
}
