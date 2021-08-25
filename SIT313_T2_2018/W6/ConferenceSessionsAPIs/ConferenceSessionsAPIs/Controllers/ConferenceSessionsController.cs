using ConferenceSessionsAPIs.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ConferenceSessionAPIs.Controllers
{
    public class ConferenceSessionsController : ApiController
    {
        List<Session> sessions = new List<Session>(
            new Session[]
            {
                new Session {SessionTitle = "Microsft", SessionDescription="Azure!"},
                new Session {SessionTitle = "Google", SessionDescription="Android!"},
                new Session {SessionTitle = "Facebook", SessionDescription="What's APP!"},
                new Session {SessionTitle = "IBM", SessionDescription="Watson!"}
            }
        );
        public List<Session> GetAll()
        {
            return sessions;
        }
        public Session GetSession(string id)
        {
            var session = sessions.FirstOrDefault((p) => p.SessionTitle == id);
            return session;
        }
    }
}
