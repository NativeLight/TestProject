
using LoginToWebSite.Base;
using LoginToWebSite.Pages;
using LoginToWebSite.UtilityClasses;
using NUnit.Framework;

namespace LoginToWebSite.Test;

public class MainPageTest : BaseTest
{
    [Test]
    public void WorkingWithGooglePage()
    {
        GooglePage googlePage = new GooglePage();
        Assert.IsTrue(googlePage.IsFormOpen());
        googlePage.SendTestDataToSearchField();
        googlePage.ClickSearchButton();
        WindowsHelper.SwitchWindow();
        googlePage.GetTitle();
    }

}