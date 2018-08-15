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
            //var handler = this.PropertyChanged;
            //if (handler != null)
            //    handler(…)
        }

        //        CurrentSession = new Session[] {
        //new SessionDetailsViewModel ("1","2","3","4")
        //    }

        List<Session> CurrentSession = new List<Session>()
        {
            new Session {SessionTitle="001", SessionSpeaker="speaker1", IsTechnical="true",SessionDescription="big data"},
            new Session {SessionTitle="002", SessionSpeaker="speaker2", IsTechnical="false",SessionDescription="art"},
            new Session {SessionTitle="003", SessionSpeaker="speaker3", IsTechnical="true",SessionDescription="history"},
            new Session {SessionTitle="004", SessionSpeaker="speaker4", IsTechnical="false",SessionDescription="it skills"},
        };


        public string SessionTitle
        {
            get { return CurrentSession[0:2].SessionTitle; }
            set
            {
                CurrentSession[0].SessionTitle = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("SessionTitle"));
            }
        }

        public string SessionSpeaker
        {
            get { return CurrentSession[0].SessionSpeaker; }
            set
            {
                CurrentSession[0].SessionSpeaker = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("SessionSpeaker"));
            }
        }

        public string IsTechnical
        {
            get { return CurrentSession[0].IsTechnical; }
            set
            {
                CurrentSession[0].IsTechnical = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("IsTechnical"));
            }
        }

        public string SessionDescription
        {
            get { return CurrentSession[0].SessionDescription; }
            set
            {
                CurrentSession[0].SessionDescription = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("SessionDescription"));
            }
        }

    }
}
