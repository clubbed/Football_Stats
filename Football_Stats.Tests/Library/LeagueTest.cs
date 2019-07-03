using Football_Stats.Library.Leagues;
using Football_Stats.Library.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Stats.Tests.Library
{
    [TestClass]
    public class LeagueTest
    {
        [TestMethod]
        public void Standings_ShouldThrowException_IfResponseIsntSuccessful()
        {
            // Arrange
            BaseLeague league = new BaseLeague();

            // Act
            var result = league.Standings(133333333);

            // Assert
            Assert.ThrowsExceptionAsync<NotImplementedException>(async () => {
                await result;
                });
        }

        [TestMethod]
        public void Standings_ShouldThrowException_ResponseNull()
        {
            BaseLeague league = new BaseLeague();

            var result = league.Standings(1932);

            Assert.ThrowsExceptionAsync<NotImplementedException>(async () =>
            {
                await result;
            });
        }

        [TestMethod]
        public void Standings_ShouldReturnLeagueModel_ResponseSuccessful()
        {
            BaseLeague league = new BaseLeague();

            var result = league.Standings(2019);

            Assert.IsInstanceOfType(result, typeof(Task<LeagueModels>));
        }
    }
}
