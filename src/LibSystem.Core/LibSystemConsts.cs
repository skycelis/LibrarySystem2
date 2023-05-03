using LibSystem.Debugging;

namespace LibSystem
{
    public class LibSystemConsts
    {
        public const string LocalizationSourceName = "LibSystem";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "559a8e5d4b804188ba7316997e1c8d68";
    }
}
