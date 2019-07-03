using Football_Stats.Library.Models;
using System.Threading.Tasks;

namespace Football_Stats.Library.Interfaces
{
    public interface ITeam
    {
        Task<TeamModel> Team();
    }
}
