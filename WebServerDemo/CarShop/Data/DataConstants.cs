namespace CarShop.Data
{
    public class DataConstants
    {
        public const int IdMaxLength = 40;
        public const int DefaultMaxLength = 20;

        public const int UserMinUserName = 4;
        public const int UserMinPassword = 5;
        public const string UserEmailRegularExpression = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"+"@"+@"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
        public const string Client = nameof(Client);
        public const string Mechanic = nameof(Mechanic);

        public const int CarModelMinLength = 5;
        public const int CatPlateNumberMaxLength = 8;
        public const string CarPlateNumberRegularExpression = @"[A-Z]{2}[0-9]{4}[A-Z]{2}";
        public const int CarYearMinValue = 1900;
        public const int CarYearMaxValue = 2100;

        public const int IssueDescriptionMinLength = 5;

    }
}
