using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Temperature
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnConvert(object sender, EventArgs e)
        {
            txtCelsius.Text = (Convert.ToInt16(txtCelsius.Text) * 1.8 + 32.0).ToString();

        }

        //void Handle_fahTextChanged(object sender, TextChangedEventArgs e)
        //{

        //    txtCelsius.Text = ((int.Parse(txtFah.Text) - 32.0) * 5 / 9).ToString();
        //}
    }
}
