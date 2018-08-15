using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace HelloAndroid
{
    [Activity(Label = "@string/app_name", MainLauncher = true, LaunchMode = Android.Content.PM.LaunchMode.SingleTop, Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity
    {

        int count = 1;
        //Define a method，The Bundle class is imported as a object 
        //Bundle is used to transmit  the data using the key-value format. YOU can use the put/get method in this class to read/write the data.
        /*
         * A basic method
         * <Access Specifier> <Return Type> <Method Name>(Parameter List)
            {
                Method Body
            }
        */

        //saveInstanceState is just a paramaters, same as "bundle" created automatically when you build a new project
        //savaInstanceSates is not equal to the OnSaveInstanceState() method in Bundle class

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.main);

            ImageView img = FindViewById<ImageView>(Resource.Id.imageView1);
            var imageSwitch = false;
            img.Click += delegate
            {
                if (imageSwitch)
                {
                    img.SetImageResource(Resource.Drawable.off);
                    imageSwitch = false;
                }
                else
                {
                    img.SetImageResource(Resource.Drawable.on);
                    imageSwitch = true;
                }
            };

            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            if (toolbar != null)
            {
                SetSupportActionBar(toolbar);
                SupportActionBar.SetDisplayHomeAsUpEnabled(false);
                SupportActionBar.SetHomeButtonEnabled(false);
            }

            // Get our button from the layout resource,
            // and attach an event to it
            var clickButton = FindViewById<Button>(Resource.Id.my_button);

            clickButton.Click += (sender, args) =>
              {
                  clickButton.Text = string.Format("{0} clicks!", count++);
              };

        }
    }
}

