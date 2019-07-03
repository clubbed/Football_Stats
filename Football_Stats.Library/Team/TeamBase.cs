using Football_Stats.Library.Client;
using Football_Stats.Library.Interfaces;
using Football_Stats.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Football_Stats.Library.Team
{
    public abstract class TeamBase : ITeam
    {
        private ApiClient _api;
        private int _teamId;

        public TeamBase(ApiClient api, int teamId)
        {
            _api = api;
            _teamId = teamId;
        }

        public virtual async Task<TeamModel> Team()
        {
            using (HttpResponseMessage response = await _api.client.GetAsync($"/v2/teams/{_teamId}"))
            {
                if(!response.IsSuccessStatusCode)
                {
                    throw new NotImplementedException();
                }

                var result = await response.Content.ReadAsAsync<TeamModel>();

                if(result == null)
                {
                    throw new NotImplementedException();
                }

                return result;
            }
        }
    }
}
