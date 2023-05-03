using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace LibrarySystem2.Localization
{
    public static class LibrarySystem2LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(LibrarySystem2Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(LibrarySystem2LocalizationConfigurer).GetAssembly(),
                        "LibrarySystem2.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
