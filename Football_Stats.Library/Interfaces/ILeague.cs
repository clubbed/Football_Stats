using Football_Stats.Library.Models;
using System.Threading.Tasks;

namespace Football_Stats.Library.Interfaces
{
    public interface ILeague
    {
        Task<LeagueModels> Standings(int id);
        Task<Scorers> TopScorers(int id);
        Task<MatchModel> Matches(int id);
    }
}
