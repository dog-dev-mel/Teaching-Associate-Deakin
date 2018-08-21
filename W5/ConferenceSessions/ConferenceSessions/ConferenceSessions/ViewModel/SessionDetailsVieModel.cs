using ConferenceSessions.Model;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ConferenceSessions.ViewModel
{
    public class SessionDetailsViewModel : INotifyPropertyChanged
    {
        //Notifies clients that a property value has changed
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //We use the Generic method to repleace the mutiple repeated logical, "set" 
        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Object.Equals(storage, value))
                return false;
            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private Session _session;
        //Set the new value to the Session
        public Session Session
        {
            set { SetProperty(ref _session, value); }
            get { return _session; }
        }

        public SessionDetailsViewModel()
        {
        }

        public void SetData(Session finalsession)
        {
             Session = finalsession ;
        }
    }
}
