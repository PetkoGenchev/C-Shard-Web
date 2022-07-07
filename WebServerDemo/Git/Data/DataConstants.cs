namespace Git.Data
{

    public class DataConstants
    {
        public const int UserNDescrMinLength = 5;
        public const int UserNPassMaxLength = 20;

        public const string UserEmailRegex = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";

    }
}