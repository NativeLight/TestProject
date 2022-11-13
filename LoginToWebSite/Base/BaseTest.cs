using LoginToWebSite.Browser;
using LoginToWebSite.UtilityClasses;
using NUnit.Framework;

namespace LoginToWebSite.Base;

[TestFixture]
public class BaseTest
{
    [SetUp]
    public void SetUp()
    {
        Serilog.Log.Debug("Begin");
        LogsManager.Logger.CreateLogger();
        ConfigManager.InitializeConfigData();
        ConfigManager.InitializeTestData();
        BrowserFactory.GetDriver().Navigate().GoToUrl(ConfigManager.testData.startingURL);
        BrowserFactory.GetDriver().Manage().Window.Maximize();
        Serilog.Log.Debug("Begin");
    }

    [TearDown]
    protected void TearDown()
    {
        BrowserFactory.CloseDriver();
    }
}
