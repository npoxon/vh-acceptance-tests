﻿namespace AcceptanceTests.Common.Driver.Support
{
    public class SauceLabsOptions
    {
        public string BrowserVersion { get; set; }
        public BrowserVersions BrowserVersions { get; set; }
        public int CommandTimeoutInSeconds { get; set; } = 60 * 3;
        public bool EnableLogging { get; set; }
        public int IdleTimeoutInSeconds { get; set; } = 60 * 7;
        public string MacPlatformVersion { get; set; } = "macOS 10.15";
        public string MacScreenResolution = "2360x1770";
        public int MaxDurationInSeconds { get; set; } = 60 * 10;

        public string SeleniumVersion = "3.141.59";
        public string Timezone = "London";
        public string Title { get; set; }
        public string WindowsScreenResolution = "2560x1600";
    }
}