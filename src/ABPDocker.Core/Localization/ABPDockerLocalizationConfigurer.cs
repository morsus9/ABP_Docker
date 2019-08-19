using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ABPDocker.Localization
{
    public static class ABPDockerLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ABPDockerConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ABPDockerLocalizationConfigurer).GetAssembly(),
                        "ABPDocker.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
