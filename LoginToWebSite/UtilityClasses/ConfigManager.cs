using Microsoft.Extensions.Configuration;
using LoginToWebSite.ConfigDataFile;
using LoginToWebSite.TestDataFile;


namespace LoginToWebSite.UtilityClasses
{
    
internal static class ConfigManager
{
    public static TestData testData;
    public static ConfigData config;

    private static string configsettingsPath = Directory.GetParent(@"../../../")?.FullName +
                                               Path.DirectorySeparatorChar + "/Resources/configSettings.json";


    private static string testDataPath = Directory.GetParent(@"../../../")?.FullName +
                                         Path.DirectorySeparatorChar + "/Resources/testSettings.json";


    public static void InitializeConfigData()
    {
        config = new ConfigData();
        ConfigurationBuilder builder = new ConfigurationBuilder();
        builder.AddJsonFile(configsettingsPath);
        IConfigurationRoot configuration = builder.Build();
        configuration.Bind(config);
    }
    public static void InitializeTestData()
    {
        testData = new TestData();
        ConfigurationBuilder builder1 = new ConfigurationBuilder();
        builder1.AddJsonFile(testDataPath);
        IConfigurationRoot configuration1 = builder1.Build();
        configuration1.Bind(testData);
    }
}
}
