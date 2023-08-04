using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;

namespace WffnEmsMaui.Test.UI;

public class MainPageTest
{
    [Fact]
    public void MainPageAccessTest()
    {
        DesiredCapabilities appCapabilities = new();
        appCapabilities.SetCapability("app", "35aa53ec-81b4-4442-af4e-db6f33853969_9zz4h110yvjzm!App");
        var mainPage = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appCapabilities);
        var button = mainPage.FindElementByAccessibilityId("CounterBtn");
        button.Click();
        Assert.Equal("Clicked 1 time", button.Text);
    }
}