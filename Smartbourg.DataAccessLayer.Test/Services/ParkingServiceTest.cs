using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Smartbourg.DataAccessLayer.Models.Parkings;
using Smartbourg.DataAccessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbourg.DataAccessLayer.Test.Services
{
    [TestClass]
    public class ParkingServiceTest
    {
        [TestMethod]
        public async Task RetrieveParkings()
        {
            List<Parking> parkings = await new ParkingService().RetrieveParkings();

            Assert.IsTrue(parkings.Count > 0, "It should have at least one parking");
            foreach (Parking parking in parkings)
            {
                Assert.IsTrue(!string.IsNullOrEmpty(parking.Name), "Parking name is null for ID {0}", parking.Id);
            }
        }
    }
}
