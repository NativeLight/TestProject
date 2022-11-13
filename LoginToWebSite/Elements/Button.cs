
using LoginToWebSite.Base;
using OpenQA.Selenium;

namespace LoginToWebSite.Elements;

internal class Button : BaseElement
{
    public Button(By locator, string name) : base(locator, name)
    {
    }
}