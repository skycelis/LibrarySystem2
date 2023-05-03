using LibrarySystem1.Debugging;

namespace LibrarySystem1
{
    public class LibrarySystem1Consts
    {
        public const string LocalizationSourceName = "LibrarySystem1";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "cd3254b54b2b4e9599cd31168dc262ec";
    }
}
