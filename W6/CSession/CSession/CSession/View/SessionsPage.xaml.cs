using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConferenceSessions.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SessionsPage : ContentPage
	{
		public SessionsPage ()
		{
			InitializeComponent ();
		}
    }
}