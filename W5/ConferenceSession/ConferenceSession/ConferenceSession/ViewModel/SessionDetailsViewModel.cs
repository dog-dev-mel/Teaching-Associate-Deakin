using ConferenceSession.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConferenceSession.View
{
    public class SessionDetailsViewModel : INotifyPropertyChanged
    {
        private Session _session;

        public Session Session
        {
            get { return _session; }
            set
            {
                //    _session = value;
                //    if (PropertyChanged != null)

                //        PropertyChanged(this, new PropertyChangedEventArgs("_session"));

                SetProperty(ref _session, value);
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
                return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        public SessionDetailsViewModel()
        {

        }

        public void SetData(Session session)
        {
            Session = session;
    }
    }
}
