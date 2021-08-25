using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ClickMeSAP
{
    public class ClickMeSAPPage : ContentPage
    {
        int clickmeCount = 0;
        public ClickMeSAPPage()
        {

            var hostlayout = new StackLayout()
            {
                Orientation = StackOrientation.Vertical
            };


            var w4t2layout = new StackLayout()
            {
                Orientation = StackOrientation.Vertical
            };

            var labelw4t2 = new Label()
            {
                Text = "Week 4/Task 2 \r\n\r\nUsing the Shared Projects (SAP) to rewrite the Task 1\r\n\r\n "
            };

            var clickbutton = new Button()
            {
                WidthRequest = 10,
                Text = "Click Me",
            };

            clickbutton.Clicked += new EventHandler(this.ButtonClicked);

            // build up the child layout
            w4t2layout.Children.Add(labelw4t2);
            w4t2layout.Children.Add(clickbutton);

            // build up the parent layout
            hostlayout.Children.Add(w4t2layout);

            // set up the Content
            Content = hostlayout;

            //set up the default padding format for all platfrom 
            hostlayout.Padding = new Thickness(0, 20, 0, 0);


            //region different platforms

            // Check the app screen, you will find the Padding on Android Platfrom  will be changed into (20,20,20,20), not the default setting (0,20,0,0)
#if __ANDROID__
            Padding = new Thickness(20, 20, 20, 20);
            System.Diagnostics.Debug.WriteLine("I'm in Android");

#endif

#if __IOS__
           Padding = new Thickness(40, 20, 40, 40);
           System.Diagnostics.Debug.WriteLine ("I'm in iOS");
#endif

            //#if __MOBILE__  
            //endif
            //the keyword __MOBILE__ can be used to set for both Xamarin.iOS and Xamarin.Android
        }

        public void ButtonClicked(object sender, EventArgs e)
        {
            clickmeCount++;
            ((Button)sender).Text = string.Format("{0} clicks!", clickmeCount);
        }
    }
}
