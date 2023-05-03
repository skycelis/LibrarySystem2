using LibrarySystem2.Debugging;

namespace LibrarySystem2
{
    public class LibrarySystem2Consts
    {
        public const string LocalizationSourceName = "LibrarySystem2";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "9b6b1fdda1ac4542857e9d7702c978a6";
    }
}
