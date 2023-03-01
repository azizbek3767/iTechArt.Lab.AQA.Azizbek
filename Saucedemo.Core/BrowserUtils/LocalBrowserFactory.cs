﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Saucedemo.Core.Utilities;
using System.ComponentModel;
using WebDriverManager.DriverConfigs.Impl;

namespace Saucedemo.Core.BrowserUtils
{
    public class LocalBrowserFactory : BrowserFactory
    {
        public LocalBrowserFactory(BrowserProfile browserProfile) : base(browserProfile)
        {
        }

        protected override WebDriver WebDriver
        {
            get
            {
                var browserName = BrowserProfile.BrowserName;
                var driverSettings = BrowserProfile.DriverSettings;
                WebDriver webDriver;
                Logger.Instance.Debug($"Start browser '{browserName}'");

                switch (browserName)
                {
                    case BrowserEnum.Chrome:
                        var options = (ChromeOptions)driverSettings.DriverOptions;
                        new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                        webDriver = new ChromeDriver(options);
                        return webDriver;
                    default:
                        throw new InvalidEnumArgumentException($"WebDriver for browser {browserName} is not supported");
                }
            }
        }
    }
}
