using System.Collections.ObjectModel;
using LoginToWebSite.Browser;
using LoginToWebSite.UtilityClasses;
using OpenQA.Selenium;

namespace LoginToWebSite.Base;

public class BaseElement
{
    
    private string elementName;
    private By locator;

    protected BaseElement(By locator, string name)
    {
        this.locator = locator;
        elementName = name;
    }
    protected IWebElement FindElement()
    {
        return BrowserFactory.GetDriver().FindElementWithWaitClickable(locator);
    }
    protected ReadOnlyCollection<IWebElement> FindElements()
    {
        return BrowserFactory.GetDriver().FindElementsExtension(locator);
    }

    public void Click()
    {
        Serilog.Log.Information($"Click on {elementName}");
        try
        {
            FindElement().Click();
        }
        catch (OpenQA.Selenium.ElementClickInterceptedException e)
        {
            Console.WriteLine(e);
        }
    }
    
    public string GetText()
    {
        Serilog.Log.Information("Get Text" + FindElement().Text);
        return FindElement().Text;
    }
    public bool IsDisplayed()
    {
        if (FindElements().Count > 0)
            Serilog.Log.Information($"Element displayed {elementName}");
        return FindElements().Count > 0;
    }
}