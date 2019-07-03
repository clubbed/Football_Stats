using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Football_Stats.Library.Client
{
    public class ApiClient
    {
        internal HttpClient client;

        public ApiClient()
        {
            client = new HttpClient();
            Initialize();
        }

        private void Initialize()
        {
            client.BaseAddress = new Uri("http://api.football-data.org");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-Auth-Token", "5aa95886af2848c4b804d7caeed3589d");
        }
    }
}
