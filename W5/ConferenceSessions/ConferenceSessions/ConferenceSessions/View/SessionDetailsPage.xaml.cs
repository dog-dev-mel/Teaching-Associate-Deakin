using ConferenceSessions.Model;
using ConferenceSessions.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConferenceSessions.View
{
    //enable the backwards compatibility.
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SessionDetailsPage : ContentPage
    {
        public SessionDetailsViewModel ViewModel { get; }
        public SessionDetailsPage(Session session)
        {
            InitializeComponent();
            //BindingContext = new SessionDetailsViewModel();
            //ViewModel = new SessionDetailsViewModel();
            //The Readability format is below;
            BindingContext = ViewModel = new SessionDetailsViewModel();
            ViewModel.SetData(session);

        }
    }
}