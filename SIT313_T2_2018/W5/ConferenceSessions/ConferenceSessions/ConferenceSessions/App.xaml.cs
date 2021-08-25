﻿using ConferenceSessions.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//enable the backwards compatibility.
[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ConferenceSessions
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SessionListPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
