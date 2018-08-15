using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClickMe
{
    public partial class MainPage : ContentPage
    {
        int clickmeCount = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        public void OnClick(object sender, EventArgs e)
        {
            clickmeCount++;
            clickmeButon.Text = string.Format("{0} clicks!", clickmeCount);
        }
    }
}
