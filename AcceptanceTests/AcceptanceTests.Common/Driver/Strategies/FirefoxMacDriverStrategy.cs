﻿using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace AcceptanceTests.Common.Driver.Strategies
{
    internal class FirefoxMacDriverStrategy : Drivers
    {
        public override RemoteWebDriver InitialiseForSauceLabs()
        {
            var browserOptions = new FirefoxOptions { PlatformName = MacPlatform, BrowserVersion = "latest", AcceptInsecureCertificates = true };
            if (!BlockedCamAndMic)
            {
                browserOptions.SetPreference("media.navigator.streams.fake", true);
                browserOptions.SetPreference("media.navigator.permission.disabled", true);
            }
            browserOptions.AddAdditionalCapability("sauce:options", SauceOptions, true);
            return new RemoteWebDriver(Uri, browserOptions);
        }

        public override IWebDriver InitialiseForLocal()
        {
            var geckoService = FirefoxDriverService.CreateDefaultService(BuildPath);
            geckoService.Host = "::1";
            var browserOptions = new FirefoxOptions();
            if (BlockedCamAndMic) return new FirefoxDriver(geckoService, browserOptions, LocalTimeout);
            browserOptions.SetPreference("media.navigator.streams.fake", true);
            browserOptions.SetPreference("media.navigator.permission.disabled", true);
            return new FirefoxDriver(geckoService, browserOptions, LocalTimeout);
        }
    }
}
