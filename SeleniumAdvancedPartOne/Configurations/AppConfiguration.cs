using PageObjectPattert.Lection.DriverConfiguration;
using PageObjectPattert.Lection.Utilities;

namespace PageObjectPattert.Lection.Configurations;

public static class AppConfiguration
{
    private const string BrowserKey = "browser";
    
    private const string UrlKey = "url";
    private const string ConditionTimeoutKey = "conditionTimeout";

    public static readonly Browser Browser = Browser.Chrome;
    //Enum.Parse<Browser>(Configurator.GetConfigurator().GetSection(BrowserKey).Value, true);

    public static readonly string Url = "https://demoqa.com/";
    //Configurator.GetConfigurator().GetSection(UrlKey).Value;
    public static readonly int ConditionTimeout = 10;
        //Convert.ToInt32(Configurator.GetConfigurator().GetSection(ConditionTimeoutKey).Value);
}