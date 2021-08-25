using System;
using System.Collections.Generic;
using System.Text;

namespace ConferenceSessions.Model
{
    public class SessionData
    {
        public static IEnumerable<Session> Get()
        {
            return new List<Session>()
            {
                new Session() { SessionTitle = "big data", SessionSpeaker = "speaker1", IsTechnical = "Yes",SessionDescription = "speaker is a ......."},
                new Session() { SessionTitle = "company managerment", SessionSpeaker = "speaker2", IsTechnical = "No",SessionDescription = "speaker is a ......."},
                new Session() { SessionTitle = "it skills", SessionSpeaker = "speaker3", IsTechnical = "Yes",SessionDescription = "speaker is a ......." },
                new Session() { SessionTitle = "history", SessionSpeaker = "speaker4", IsTechnical = "No", SessionDescription = "speaker is a ......."  },
                new Session() { SessionTitle = "software programming", SessionSpeaker = "speaker5", IsTechnical = "Yes", SessionDescription = "speaker is a ......."  },
                new Session() { SessionTitle = "prestation skill", SessionSpeaker = "speaker6", IsTechnical = "No", SessionDescription = "speaker is a ......."  },
                new Session() { SessionTitle = "research method", SessionSpeaker = "speaker7", IsTechnical = "Yes", SessionDescription = "speaker is a ......."  },
                new Session() { SessionTitle = "art", SessionSpeaker = "speaker8", IsTechnical = "No", SessionDescription = "time management"  }
            };
        }
    }
}