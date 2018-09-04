using System;
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
                //return ConfigureApp.Android.InstalledApp("com.companyname.CalculatorApp").StartApp();
                //return ConfigureApp.Android.ApkFile("../../../CalculatorApp/bin/Debug/CalculatorApp.CalculatorApp.apk").StartApp();
                return ConfigureApp.Android.InstalledApp("com.companyname.CalculatorApp").PreferIdeSettings().EnableLocalScreenshots().StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}