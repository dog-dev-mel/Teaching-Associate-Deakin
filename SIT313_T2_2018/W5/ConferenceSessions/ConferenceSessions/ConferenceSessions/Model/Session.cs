using System;
using System.Collections.Generic;
using System.Text;

namespace ConferenceSessions.Model
{
    public class Session
    {
        public string SessionTitle { get; set; }
        public string SessionSpeaker { get; set; }
        public string IsTechnical { get; set; }
        public string SessionDescription { get; set; }
    }
}
