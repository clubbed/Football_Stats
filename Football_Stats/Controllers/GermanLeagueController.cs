using Football_Stats.Library.Interfaces;
using Football_Stats.Library.Models;
using System.Threading.Tasks;
using System.Web.Mvc;
using PagedList;

namespace Football_Stats.Controllers
{
    public class GermanLeagueController : Controller
    {

        private ILeague _league;
        private readonly int _competitionId = 2002;

        public GermanLeagueController(ILeague league)
        {
            _league = league;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            LeagueModels model = await _league.Standings(_competitionId);

            return View(model.standings);
        }

        [HttpGet]
        public async Task<ActionResult> Scorers()
        {
            var scorers = await _league.TopScorers(_competitionId);

            return View(scorers);
        }

        [HttpGet]
        public async Task<ActionResult> Matches(int? page)
        {
            MatchModel model = await _league.Matches(_competitionId);

            return View(model.matches.ToPagedList(page ?? 1, 10));
        }
    }
}