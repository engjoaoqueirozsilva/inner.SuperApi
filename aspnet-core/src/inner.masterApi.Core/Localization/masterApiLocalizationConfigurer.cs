using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace inner.masterApi.Localization
{
    public static class masterApiLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(masterApiConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(masterApiLocalizationConfigurer).GetAssembly(),
                        "inner.masterApi.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
