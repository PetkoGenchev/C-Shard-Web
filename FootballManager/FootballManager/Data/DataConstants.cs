namespace FootballManager.Data
{

    public class DataConstants
    {
        public const int DefaultMinLength = 5;
        public const int DefaultMaxLength = 20;
        public const int EmailMinLength = 10;
        public const int EmailMaxLength = 60;
        public const string UserEmailRegex = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";

        public const int FullNameMaxLength = 80;
        public const int SpeedandEnduranceMinValue = 0;
        public const int SpeedandEnduranceMaxValue = 10;
        public const int DescriptionMaxLength = 200;



    }
}
