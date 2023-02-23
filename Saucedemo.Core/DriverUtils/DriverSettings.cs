using OpenQA.Selenium;

namespace Saucedemo.Core.DriverUtils
{
    public abstract class DriverSettings
    {
        public abstract DriverOptions DriverOptions { get; }
    }
}
