namespace LoginToWebSite.Base;

public class BaseForm
{
    private string formName;
    private BaseElement uniqElement;

    protected BaseForm(BaseElement uniqElement, string formName)
    {
        this.uniqElement = uniqElement;
        this.formName = formName;
    }

    public bool IsFormOpen()
    {
        Serilog.Log.Information($"{formName} Is Opened");
        return uniqElement.IsDisplayed();
    }
}