using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConferenceSession.Model
{
    public class Session
    {
        public Session()
        {
        }

        public Session(string value1, string value2, string value3, string value4)
        {
            this.SessionTitle = value1;
            this.SessionSpeaker = value2;
            this.IsTechnical = value3;
            this.SessionDescription = value4;
        }

        public string SessionTitle { get; set; }
        public string SessionSpeaker { get; set; }
        public string IsTechnical { get; set; }
        public string SessionDescription { get; set; }

        public override string ToString()
        {
            return string.Format("[SessionTitle={0}, SessionSpeaker={1}, IsTechnical={2},SessionDescription={3}]", SessionTitle, SessionSpeaker, IsTechnical, SessionDescription);
        }
    }
}
