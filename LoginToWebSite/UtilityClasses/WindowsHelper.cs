using System.Collections.ObjectModel;
using LoginToWebSite.Browser;

namespace LoginToWebSite.UtilityClasses;

public class WindowsHelper
{
    private static readonly string firstWindowId = BrowserFactory.GetDriver().CurrentWindowHandle;
    private static ReadOnlyCollection<string> windows = BrowserFactory.GetDriver().WindowHandles;
    public static void SwitchWindow()
    {
        foreach (var id in windows)
        {
            if (!id.Contains(firstWindowId))
            {
                BrowserFactory.GetDriver().SwitchTo().Window(id);
            }
        }
    }
}