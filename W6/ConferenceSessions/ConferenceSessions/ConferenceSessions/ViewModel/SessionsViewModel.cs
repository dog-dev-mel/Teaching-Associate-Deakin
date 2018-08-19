using ConferenceSessions.Data;
using ConferenceSessions.Model;
using ConferenceSessions.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConferenceSessions.ViewModel
{
    public class SessionsViewModel : INotifyPropertyChanged
    {
        SessionsManager sessionsManager = new SessionsManager();

        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Session> _sessionslist;

        public ObservableCollection<Session> SessionsList
        {
            get { return _sessionslist; }
            set
            {
                _sessionslist = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("SessionsList"));
                }
            }
        }

        public SessionsViewModel()
        {
            FetchDataAsync();
        }

        public async Task FetchDataAsync()
        {
            var list = await sessionsManager.FetchSessionsAsync();
            SessionsList = new ObservableCollection<Session>(list);
            //System.Diagnostics.Debug.WriteLine("...................................................................................................");
            //System.Diagnostics.Debug.WriteLine(SessionsList.Count);
            //System.Diagnostics.Debug.WriteLine("...................................................................................................");
        }
    }
}
