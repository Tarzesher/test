using SBSA.Recon.Tool.WebApi.Controllers;
using System;
using System.Linq;
using Xunit;

namespace SBSA.Recon.Tool.WebApiTest
{
    public class ReconStatsTest
    {
        [Fact]
        public async void ReadQueryStats()
        {
            var ctrl = new StatsController();

            //Assign
            var expected = await ctrl.ReadStats();

            var count = expected.ToList();
            //Assert
            Assert.NotNull(expected);
        }
    }
}