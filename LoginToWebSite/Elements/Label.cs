using LoginToWebSite.Base;
using OpenQA.Selenium;

namespace LoginToWebSite.Elements;
internal class Label : BaseElement
    {
        public Label(By locator, string name) : base(locator, name)
        {
        }
    }

