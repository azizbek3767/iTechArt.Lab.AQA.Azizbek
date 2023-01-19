﻿using OpenQA.Selenium;

namespace SeleniumWebDriverBasics.Locators
{
    internal static class HomePageLocators
    {
        public static readonly By AppleManufacturerSpanLocator = By.XPath("//*[@id=\"schema-filter\"]/div[5]/div[4]/div[2]/ul/li[1]/label/span[2]");
        public static readonly By AppleManufacturerInputLocator = By.XPath("//*[@id=\'schema-filter\']/div[5]/div[4]/div[2]/ul/li[1]/label/span[1]/input");
        public static readonly By HonorManufacturerSpanLocator = By.XPath("//*[@id=\"schema-filter\"]/div[5]/div[4]/div[2]/ul/li[5]/label/span[2]");
        public static readonly By HonorManufacturerInputLocator = By.XPath("//*[@id=\"schema-filter\"]/div[5]/div[4]/div[2]/ul/li[5]/label/span[1]/input");
        public static readonly By PhonesListLocator = By.XPath("//div[@class='schema-product__group']/div/div[3]/div[2]/div/a/span");
        public static readonly By FirstItemCheckboxLabel = By.XPath("//*[@id=\"schema-products\"]/div[2]/div/div[1]/div[1]/div/label");
        public static readonly By ThirdItemCheckboxLabel = By.XPath("//*[@id=\"schema-products\"]/div[5]/div/div[1]/div[1]/div/label");
        public static readonly By FirstItemCheckboxInput = By.XPath("//*[@id=\"schema-products\"]/div[2]/div/div[1]/div[1]/div/label/span/input");
        public static readonly By ThirdItemCheckboxInput = By.XPath("//*[@id=\"schema-products\"]/div[5]/div/div[1]/div[1]/div/label/span/input");

    }
}
