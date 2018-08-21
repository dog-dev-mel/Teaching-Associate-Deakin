using ConferenceSession.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConferenceSessions.View
{
    //enable the backwards compatibility.
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SessionListPage : ContentPage
	{
		public SessionListPage ()
		{
            InitializeComponent();
            //To bind the SeesionListPage with SessionListViewModel
            BindingContext = new SessionListViewModel(Navigation);
        }
	}
}