using SeleniumAdvancedPartOne.Pages;

namespace PageObjectPattert.Lection.Tests;

public abstract class BaseTest
{
    protected IWebDriver WebDriver { get; private set; }
    protected HomePage HomePage { get; private set; }
    
    [SetUp]
    public void SetUp()
    {
        WebDriver = new WebDriverFactory().GetDriver();
        WebDriver.Manage().Window.Maximize();
        
        HomePage = new HomePage(WebDriver);
    }

    [TearDown]
    public void TearDown()
    {
        WebDriver.Quit();
    }
}
