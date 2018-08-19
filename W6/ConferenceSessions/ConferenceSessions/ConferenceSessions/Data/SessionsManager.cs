﻿using ConferenceSessions.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceSessions.Data
{
    public class SessionsManager
    {
        HttpClient client = new HttpClient();

        //public List<Session> ConferenceSessions { get; private set; }
        List<Session> ConferenceSessions = null;

        public async Task<List<Session>> FetchSessionsAsync()
        {
            
            string url = "http://192.168.1.4:45455/api/conferencesessions";
            try
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    ConferenceSessions = JsonConvert.DeserializeObject<List<Session>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }
            return ConferenceSessions;
        }
    }
}
