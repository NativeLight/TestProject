using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using SeleniumExtras.WaitHelpers;

namespace LoginToWebSite.UtilityClasses;
public static class WaitExtensions
{
    public static IWebElement FindElementExtension(this IWebDriver driver, By by)
    {
        int timeoutInSeconds = ConfigManager.config.timeoutInSeconds;
        if (timeoutInSeconds > 0)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(drv => drv.FindElement(by));
        }
        return driver.FindElement(by);
    }

    public static ReadOnlyCollection<IWebElement> FindElementsExtension(this IWebDriver driver, By by)
    {
        int timeoutInSeconds = ConfigManager.config.timeoutInSeconds;
        if (timeoutInSeconds > 0)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(drv => drv.FindElements(by));
        }
        return driver.FindElementsExtension(by);
    }
    public static IWebElement FindElementWithWaitClickable(this IWebDriver driver, By by)
    {
        int timeoutInSeconds = ConfigManager.config.timeoutInSeconds;
        if (timeoutInSeconds > 0)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }
        return driver.FindElement(by);
    }
}