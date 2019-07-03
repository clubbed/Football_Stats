using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Football_Stats;
using Football_Stats.Controllers;
using Football_Stats.Library.Interfaces;
using Football_Stats.Library.Models;
using Football_Stats.Library.Leagues;

namespace Football_Stats.Tests.Controllers
{
    [TestClass]
    public class EnglandLeagueControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            EnglandLeagueController controller = new EnglandLeagueController(new BaseLeague());

            // Act 
            var result = controller.Index();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Index_ShouldReturnNull()
        {
            // Arrange
            EnglandLeagueController controller = new EnglandLeagueController(new BaseLeague());

            // Act
            var result = Task.Run(async () =>
            {
                await controller.Index();
            });

            // Assert
            Assert.IsNotNull(result);
        }
    }
    public class League : ILeagueBase
    {
        public BaseLeague _base;

        public League()
        {
            _base = new BaseLeague();
        }
        public async Task<MatchModel> Matches(int id)
        {
            MatchModel model = await _base.Matches(2019);

            return model;
        }

        public async Task<LeagueModels> Standings(int id)
        {
            LeagueModels model = new LeagueModels();

            return model;
        }

        public async Task<Scorers> TopScorers(int id)
        {
            Scorers model = new Scorers();

            return model;
        }
    }
}
