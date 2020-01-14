﻿using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace AcceptanceTests.Common.Driver.Strategies
{
    internal class FirefoxMacDriverStrategy : Drivers
    {
        public override RemoteWebDriver InitialiseForSauceLabs()
        {
            var ffOptions = new FirefoxOptions { PlatformName = MacPlatform, BrowserVersion = "latest", AcceptInsecureCertificates = true };
            if (!BlockedCamAndMic)
            {
                ffOptions.SetPreference("media.navigator.streams.fake", true);
                ffOptions.SetPreference("media.navigator.permission.disabled", true);
            }
            ffOptions.AddAdditionalCapability("sauce:options", SauceOptions, true);
            return new RemoteWebDriver(Uri, ffOptions);
        }

        public override IWebDriver InitialiseForLocal()
        {
            var geckoService = FirefoxDriverService.CreateDefaultService(BuildPath);
            geckoService.Host = "::1";
            var ffOptions = new FirefoxOptions();
            if (BlockedCamAndMic) return new FirefoxDriver(geckoService, ffOptions, LocalTimeout);
            ffOptions.SetPreference("media.navigator.streams.fake", true);
            ffOptions.SetPreference("media.navigator.permission.disabled", true);
            return new FirefoxDriver(geckoService, ffOptions, LocalTimeout);
        }
    }
}