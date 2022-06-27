namespace CarShop.Services
{
    using CarShop.Models.Cars;
    using CarShop.Models.Users;
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using static Data.DataConstants;

    public class Validator : IValidator
    {
        public ICollection<string> ValidateUser(RegisterUserFormModel model)
        {
            var errors = new List<string>();

            if(model.Username.Length < UserMinUserName ||
                model.Username.Length > DefaultMaxLength)
            {
                errors.Add($"Username '{model.Username}' is not valid. It must be over {UserMinUserName} and below {DefaultMaxLength} symbols.");
            }


            if (!Regex.IsMatch(model.Email, UserEmailRegularExpression))
            {
                errors.Add($"Email '{model.Email}' is not valid. It must be over {UserMinPassword} symbols.");
            }


            if (model.Password.Length < UserMinPassword ||
    model.Password.Length > DefaultMaxLength)
            {
                errors.Add($"Password '{model.Username}' is not valid. It must be over {UserMinPassword} and below {DefaultMaxLength} symbols.");
            }

            if (model.Password != model.ConfirmPassword)
            {
                errors.Add("Password and Confirm password must be the same!");
            }


            if (model.UserType != Client && model.UserType != Mechanic)
            {
                errors.Add($"User should be either a '{Mechanic}' or a '{Client}'");
            }

            return errors;
        }

        public ICollection<string> ValidateCar(AddCarFormModel model)
        {
            var errors = new List<string>();

            if (model.Model.Length < CarModelMinLength ||
                model.Model.Length > DefaultMaxLength)
            {
                errors.Add($"Model '{model.Model}' is not valid. It must be over {CarModelMinLength} and below {DefaultMaxLength} symbols.");
            }


            if (model.Year < CarYearMinValue || model.Year > CarYearMaxValue)
            {
                errors.Add($"Year '{model.Year}' is not valid. It must be over {CarYearMinValue} and below {CarYearMaxValue}.");
            }


            if (Uri.IsWellFormedUriString(model.Image,UriKind.Absolute))
            {
                errors.Add($"Image {model.Image} is not a valid URL!");
            }


            if (!Regex.IsMatch(model.PlateNumber, CarPlateNumberRegularExpression))
            {
                errors.Add($"Plate Number '{model.PlateNumber}' is not valid. It must be in format 'AA1234AA'.");
            }


            return errors;

        }
    }
}
