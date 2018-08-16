using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ConferenceSession.Model;

namespace ConferenceSession.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SessionDetailsPage : ContentPage
	{
        public SessionDetailsViewModel ViewModel { get; }
        public SessionDetailsPage(Session session)
        {

            InitializeComponent();

            BindingContext = ViewModel = new SessionDetailsViewModel(); ;

            ViewModel.SetData(session);
        }
	}
}