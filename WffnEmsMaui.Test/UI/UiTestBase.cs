using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;

namespace WffnEmsMaui.Test.UI;

public abstract class UiTestBase : IDisposable
{
    protected readonly WindowsDriver<WindowsElement> Driver;

    protected UiTestBase()
    {
        DesiredCapabilities appCapabilities = new();
        appCapabilities.SetCapability("app", "35aa53ec-81b4-4442-af4e-db6f33853969_agc50t4gbzpde!App");
        Driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appCapabilities);
    }

    public void Dispose()
    {
        Driver.CloseApp();
    }
}