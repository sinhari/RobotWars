using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars.Business;
using RobotWars.Business.Model;

namespace RobotWars.Test
{
    [TestClass]
    public class AcceptanceTests
    {
        [TestMethod]
        public void Should_return_expected_coords_and_orientation_Input_Robot2()
        {
            var x = 3;
            var y = 3;
            var direction = "E";
            List<string> movements = new List<string>()
            {
                "M",
                "M",
                "R",
                "M",
                "M",
                "R",
                "M",
                "R",
                "R",
                "M"
            };


            Coordinates robotCoordinates = Controller.RobotController(x, y, direction, movements);
            Coordinates expectedCoordinates = new Coordinates()
            {
                Xaxis = 5,
                Yaxis = 1,
                Orientation = "E"
            };

            Assert.AreEqual(robotCoordinates.Orientation, expectedCoordinates.Orientation);
            Assert.AreEqual(robotCoordinates.Xaxis, expectedCoordinates.Xaxis);
            Assert.AreEqual(robotCoordinates.Yaxis, expectedCoordinates.Yaxis);
        }

        [TestMethod]
        public void Should_return_expected_coords_and_orientation_Input_Robot1()
        {
            var x = 1;
            var y = 2;
            var direction = "N";
            List<string> movements = new List<string>()
            {
                "L",
                "M",
                "L",
                "M",
                "L",
                "M",
                "L",
                "M",
                "M"
            };


            Coordinates robotCoordinates = Controller.RobotController(x, y, direction, movements);
            Coordinates expectedCoordinates = new Coordinates()
            {
                Xaxis = 1,
                Yaxis = 3,
                Orientation = "N"
            };

            Assert.AreEqual(robotCoordinates.Orientation, expectedCoordinates.Orientation);
            Assert.AreEqual(robotCoordinates.Xaxis, expectedCoordinates.Xaxis);
            Assert.AreEqual(robotCoordinates.Yaxis, expectedCoordinates.Yaxis);
        }
    }
}
