namespace MedicDomusLK.DataConstants
{
    public static class Validations
    {
        public static class ApplicationUserConst
        {
            public const int FirstNameMaxLength = 50;
            public const int FirstNameMinLength = 2;

            public const int LastNameMaxLength = 50;
            public const int LastNameMinLength = 2;

            public const int StreetMaxLength = 120;
            public const int StreetMinLength = 2;
        }

        public static class HometownConst
        {
            public const int PlzSize = 5;

            public const int NameMaxLength = 60;
            public const int NameMinLength = 2;
        }

        public static class ServiceConst
        {
            public const int NameMaxLength = 100;
            public const int NameMinLength = 2;

            public const double PriceMax = 299.99;
        }
    }
}
