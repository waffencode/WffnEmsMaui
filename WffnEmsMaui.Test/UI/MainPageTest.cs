using OpenQA.Selenium.Appium.Windows;

namespace WffnEmsMaui.Test.UI;

public class MainPageTest : UiTestBase
{
    [Fact]
    public void MainPageAccessTest()
    {
        WindowsElement? button = Driver.FindElementByAccessibilityId("CounterBtn");
        Assert.NotNull(button);
        button.Click();
        Assert.Equal("Clicked 1 time", button.Text);
    }
}