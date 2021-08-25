using Android.App;
using Android.Widget;
using Android.OS;
using Android.Util;
using System;
using Android.Content;
using Android;

namespace Size_Qualifiers
{
    [Activity(Label = "W2", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        int count = 0;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            Log.Info("W2", "OnCreate");
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.main);


            Button counterBtn = FindViewById<Button>(Resource.Id.my_button);
            counterBtn.Click += new EventHandler(this.Button1Clicked);

            if (savedInstanceState != null)
            {
                //GetInt
                count = savedInstanceState.GetInt("counter");
                counterBtn.Text = string.Format("{0} clicks!", count);
            }


            Button showListBtn = FindViewById<Button>(Resource.Id.mybutton1);
            showListBtn.Click += delegate
                {

                    var newActivity = new Intent(this, typeof(StudentsListActivity));
                    StartActivity(newActivity);
                };

        }


        public void Button1Clicked(object sender, EventArgs e)
        {

            Log.Info("W2", "myButton - Clicked");
            count++;
            ((Button)sender).Text = string.Format("{0} clicks!", count);
        }

        //PutInt
        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            Log.Info("W2", "OnSaveInstanceState");
            outState.PutInt("counter", count);
        }

        protected override void OnPause()
        {
            Log.Info("W2", "OnPause");
            base.OnPause();
        }

        protected override void OnStop()
        {
            Log.Info("W2", "OnStop");
            base.OnStop();
        }

        protected override void OnDestroy()
        {
            Log.Info("W2", "OnDestroy");
            base.OnDestroy();
        }
        protected override void OnStart()
        {

            Log.Info("W2", "OnStart");
            base.OnStart();
        }

        protected override void OnResume()
        {

            Log.Info("W2", "OnResume");
            base.OnResume();
        }
    }
}