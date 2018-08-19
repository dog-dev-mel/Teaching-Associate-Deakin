using System;
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
            string url = "http://192.168.1.4:45455/api/conferencesessions";

            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                ConferenceSessions = JsonConvert.DeserializeObject<List<Session>>(content);
            }

            Console.WriteLine("list");
            Console.WriteLine(ConferenceSessions);

            return ConferenceSessions;

        }

    }
}
