using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Interactions;

namespace Appium2Version;

[TestClass]
public class UnitTest1
{
    public AndroidDriver androidDriver;

    [TestMethod]
    public void TestMethod1()
    {
        var appiumOptions = new AppiumOptions();
        appiumOptions.AutomationName = "UiAutomator2";
        appiumOptions.DeviceName = "emulator";
        appiumOptions.App = "/Users/shiva/Documents/Appium2Version/Appium2Version/Naukri.apk";
        appiumOptions.PlatformName = "Android";
        appiumOptions.PlatformVersion = "12.0";

        //appiumOptions.AddAdditionalAppiumOption("appium:options.deviceName", "emulator"); - work
       // appiumOptions.AddAdditionalAppiumOption("appium:platformName", "Android"); - work
      //  appiumOptions.AddAdditionalAppiumOption("appium:options.platformVersion", "12.0"); - work 
      //  appiumOptions.AddAdditionalAppiumOption("appium:options.app", "/Users/shiva/Documents/Appium2Version/Appium2Version/Naukri.apk"); - work

       // appiumOptions.AddAdditionalAppiumOption("appium:options.automationName", "UiAutomator2"); -- deprecated

        androidDriver = new AndroidDriver(new Uri("http://127.0.0.1:4723"), appiumOptions);

        androidDriver.FindElement(By.XPath("//*[@text='Login']")).Click();
    }
}
