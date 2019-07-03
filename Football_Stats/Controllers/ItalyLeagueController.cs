using Football_Stats.Library.Interfaces;
using Football_Stats.Library.Models;
using System.Threading.Tasks;
using System.Web.Mvc;
using PagedList;

namespace Football_Stats.Controllers
{
    public class ItalyLeagueController : Controller
    {
        private ILeague _league;
        private readonly int _competitonId = 2019;

        public ItalyLeagueController(ILeague league)
        {
            _league = league;
        }
    
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            LeagueModels models = await _league.Standings(_competitonId);
            
            return View(models.standings);
        }

        [HttpGet]
        public async Task<ActionResult> Scorers()
        {
            var scorers = await _league.TopScorers(_competitonId);

            return View(scorers);
        }

        [HttpGet]
        public async Task<ActionResult> Matches(int? page)
        {
            var model = await _league.Matches(_competitonId);

            return View(model.matches.ToPagedList(page ?? 1, 10));
        }
    }
}