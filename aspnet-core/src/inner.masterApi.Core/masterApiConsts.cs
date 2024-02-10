using inner.masterApi.Debugging;

namespace inner.masterApi
{
    public class masterApiConsts
    {
        public const string LocalizationSourceName = "masterApi";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "535a15cc587e43e993872cf3b836350c";
    }
}
