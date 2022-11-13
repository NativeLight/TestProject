using LoginToWebSite.Base;
using OpenQA.Selenium;

namespace LoginToWebSite.Elements;

internal class Input : BaseElement
{
    public Input(By locator, string name) : base(locator, name)
    {
    }
    public void SendText(string text)
    {
        Serilog.Log.Information($"Send keys {text}");
        FindElement().SendKeys(text);
    }
}