
using LoginToWebSite.Base;
using LoginToWebSite.Browser;
using LoginToWebSite.Elements;
using LoginToWebSite.UtilityClasses;
using OpenQA.Selenium;


namespace LoginToWebSite.Pages
{

    internal class GooglePage : BaseForm
    {
        private static Input  searchField   => new(By.XPath("//input[contains(@name,'q')]"), "searchField");
        private static Label  uniqueElement => new(By.XPath("//img[contains(@alt,'Google')]"), "Google main page logo");
        private static Button searchButton  => new(By.XPath("//input[contains(@class,'gNO89b')]"), "Search button");
       
        
        public GooglePage() : base(uniqueElement, "Main page logo")
        {
        }

        public void SendTestDataToSearchField()
        {
             searchField.SendText(ConfigManager.testData.searchFieldInputData);
        }

        public void ClickSearchButton()
        {
            searchButton.Click();
        }
        public void GetTitle()
        {
            Serilog.Log.Information(BrowserFactory.GetDriver().Title);
        }
    }
}