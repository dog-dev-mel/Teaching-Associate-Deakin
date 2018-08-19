using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ConferenceSessions.Model;
using Newtonsoft.Json;

namespace ConferenceSessions.Data
{
    class SessionsManager
    {
        HttpClient client = new HttpClient();
        List<Session> ConferenceSessions = null;

        public async Task<List<Session>> FetchSessionsAsync()
        {
            string url = "http://127.0.0.1:8088/api/conferencesessions";

            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                ConferenceSessions = JsonConvert.DeserializeObject<List<Session>>(content);
            }
            return ConferenceSessions;
        }

    }
}
