using Football_Stats.Library.Client;
using Football_Stats.Library.Interfaces;
using Football_Stats.Library.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Football_Stats.Library.Leagues
{
    public class LeagueBase : ILeague
    {
        private readonly ApiClient _api;
        
        public LeagueBase(ApiClient api)
        {
            _api = api;
        }

        public virtual async Task<MatchModel> Matches(int id)
        {
            using (HttpResponseMessage response = await _api.client.GetAsync($"v2/competitions/{id}/matches"))
            {
                if(!response.IsSuccessStatusCode)
                {
                    throw new NotImplementedException();
                }

                var result = await response.Content.ReadAsAsync<MatchModel>();

                if(result == null)
                {
                    throw new NotImplementedException();
                }

                return result;
            }
        }

        public virtual async Task<LeagueModels> Standings(int id)
        {
            using (HttpResponseMessage response = await _api.client.GetAsync($"v2/competitions/{id}/standings?standingType=TOTAL"))
            {
                if (!response.IsSuccessStatusCode)
                {
                    // TODO
                    throw new NotImplementedException();
                }
                var result = await response.Content.ReadAsAsync<LeagueModels>();

                if (result == null)
                {
                    throw new NotImplementedException();
                }

                return result;
            }
        }

        public virtual async Task<Scorers> TopScorers(int id)
        {
            using (HttpResponseMessage response = await _api.client.GetAsync($"v2/competitions/{id}/scorers"))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new NotImplementedException();
                }

                var result = await response.Content.ReadAsAsync<Scorers>();

                //var json = await response.Content.ReadAsStringAsync();

                //var result = JsonConvert.DeserializeObject<Scorers>(json);

                //string json = "";
                //var stream = await response.Content.ReadAsStreamAsync();
                //using (var reader = new StreamReader(stream))
                //{
                //    json = reader.ReadToEnd();
                //}

                //Scorers result = (Scorers)JsonConvert.DeserializeObject(json);

                if (result == null)
                {
                    throw new NotImplementedException();
                }

                return result;
            }
        }
    }
}
