﻿using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Calculator.UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                       .Android
                       .InstalledApp("com.companyname")
                       //.ApkFile(@"F:\CalculatorApp\CalculatorApp\CalculatorApp.Android\bin\Debug\com.companyname.apk")
                       .DeviceSerial("emulator-5554")
                       .PreferIdeSettings()
                       .EnableLocalScreenshots()
                       .StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}