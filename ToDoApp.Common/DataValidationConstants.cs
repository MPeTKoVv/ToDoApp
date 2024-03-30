namespace ToDoApp.Common
{
    static public class DataValidationConstants
    {
        public static class ToDo
        {
            public const int TitleMinLength = 1;
            public const int TitleMaxLength = 100;

            public const int DescriptionMinLength = 1;
            public const int DescriptionMaxLength = 1000;
        }

        public static class Category
        {
            public const int NameMinLength = 1;
            public const int NameMaxLength = 50;

            public const int UrlMinLength = 5;
            public const int UrlMaxLength = 2048;
        }
    }
}

