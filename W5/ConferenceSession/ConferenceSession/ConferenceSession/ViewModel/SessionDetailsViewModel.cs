using ConferenceSession.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConferenceSession.View
{
    public class SessionDetailsViewModel
    {
        private Session _session;

        public Session Session
        {
            get { return _session; }
            set => SetProperty(ref _session, value);
        }

        private void SetProperty(ref Session session, Session value)
        {
            throw new NotImplementedException();
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
