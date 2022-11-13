
 using LoginToWebSite.UtilityClasses;
 using OpenQA.Selenium.Chrome;
 using OpenQA.Selenium;
 using OpenQA.Selenium.Firefox;
 using WebDriverManager.DriverConfigs.Impl;

 namespace LoginToWebSite.Browser;

 internal static class BrowserFactory
 {
     private static IWebDriver? driver;

     internal static IWebDriver GetDriver()
     {
         if (driver == null)
         {
             switch (ConfigManager.config.browserType.ToLower())
             {
                 case "chrome":
                     new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                     ChromeOptions chromeOptions = new ChromeOptions();
                     chromeOptions.AddArgument(ConfigManager.config.browserSettings);
                     driver = new ChromeDriver(chromeOptions);
                     Serilog.Log.Debug("Navigated to {0} on chrome browser", ConfigManager.testData.startingURL);
                     break;
                 case "firefox":
                     new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                     FirefoxOptions firefoxOptions = new FirefoxOptions();
                     firefoxOptions.AddArgument(ConfigManager.config.browserSettings);
                     driver = new FirefoxDriver(firefoxOptions);
                     Serilog.Log.Debug("Navigated to {0} on firefox browser", ConfigManager.testData.startingURL);
                     break;
                 default:
                     Serilog.Log.Debug("No such Browser");
                     throw new ApplicationException("No such browser");
             }
         }
         return driver;
     }
     
     public static void CloseDriver()
     {
         if (driver is not null)
         {
             Serilog.Log.Debug("Driver is closed");
             driver.Quit();
             driver = null;
         }
     }
 }