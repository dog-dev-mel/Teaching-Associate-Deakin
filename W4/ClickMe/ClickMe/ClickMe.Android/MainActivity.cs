using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Util;

namespace ClickMe.Droid
{
    [Activity(Label = "ClickMe", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            Log.Info("X.Android", "OnCreate");

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }

        protected override void OnStart()
        {

            Log.Info("X.Android", "OnStart");
            base.OnStart();
        }

        protected override void OnResume()
        {

            Log.Info("X.Android", "OnResume");
            base.OnResume();
        }

        protected override void OnPause()
        {
            Log.Info("X.Android", "OnPause");
            base.OnPause();
        }

        protected override void OnStop()
        {
            Log.Info("X.Android", "OnStop");
            base.OnStop();
        }

        protected override void OnRestart()
        {

            Log.Info("X.Android", "OnRestart");
            base.OnRestart();
        }

        protected override void OnDestroy()
        {
            Log.Info("X.Android", "OnDestroy");
            base.OnDestroy();
        }
    }
}

