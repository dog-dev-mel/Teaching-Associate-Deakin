using ConferenceSessions.Model;
using ConferenceSessions.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace ConferenceSession.View
{
    public class SessionListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private INavigation _navigation;
        public List<Session> Sessions { get; set; }
        public SessionListViewModel(INavigation navigation)
        {
            _navigation = navigation;
            Sessions = new List<Session>(SessionData.Get());
        }

        private Session _sessionSelected;
        public Session SessionSelected
        {
            get { return _sessionSelected; }
            set
            {
                if (_sessionSelected != value)
                {
                    _sessionSelected = value;

                    if ((_sessionSelected != null))
                    {
                        _navigation.PushAsync(new SessionDetailsPage(_sessionSelected));
                    }
                }
            }
        }


    }
}
