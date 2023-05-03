using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace LibrarySystem1.Localization
{
    public static class LibrarySystem1LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(LibrarySystem1Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(LibrarySystem1LocalizationConfigurer).GetAssembly(),
                        "LibrarySystem1.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
