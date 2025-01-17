﻿using AcceptanceTests.Common.Driver.Enums;

namespace AcceptanceTests.Common.Driver.Settings
{
    public class DriverOptions
    {
        public TargetDeviceOrientation TargetDeviceOrientation { get; set; }
        public bool HeadlessMode { get; set; } = false;
        public int LocalAppiumCommandTimeoutInSeconds { get; set; } = 20;
        public int LocalCommandTimeoutInSeconds { get; set; } = 20;
        public string PlatformVersion { get; set; } = "13.2";
        public bool RealDevice { get; set; } = true;
        public bool ResetDeviceBetweenTests { get; set; } = false;
        public TargetBrowser TargetBrowser { get; set; }
        public string TargetBrowserVersion { get; set; }
        public TargetDevice TargetDevice { get; set; }
        public string TargetDeviceName { get; set; }
        public TargetOS TargetOS { get; set; }
        public string UUID { get; set; }
    }
}
