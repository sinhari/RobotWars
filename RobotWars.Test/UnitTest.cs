using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars.Business;
using RobotWars.Business.Model;

namespace RobotWars.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Should_return_expected_coords_and_orientation_if_start_and_end_position_are_same()
        {
            var x = 1;
            var y = 1;
            var direction = "N";
            List<string> movements = new List<string>()
            {
                "R",
                "M",
                "R",
                "M",
                "R",
                "M",
                "R",
                "M"
            };


            Coordinates robotCoordinates = Controller.RobotController(x, y, direction, movements);
            Coordinates expectedCoordinates = new Coordinates()
            {
                Xaxis = 1,
                Yaxis = 1,
                Orientation = "N"
            };

            Assert.AreEqual(robotCoordinates.Orientation, expectedCoordinates.Orientation);
            Assert.AreEqual(robotCoordinates.Xaxis, expectedCoordinates.Xaxis);
            Assert.AreEqual(robotCoordinates.Yaxis, expectedCoordinates.Yaxis);
        }

        [TestMethod]
        public void Should_return_expected_coords_and_orientation_if_there_are_more_movements_and_one_turn()
        {
            var x = 5;
            var y = 5;
            var direction = "S";
            List<string> movements = new List<string>()
            {
                "M",
                "M",
                "M",
                "M",
                "M",
                "R",
                "M",
                "M",
                "M",
                "M",
                "M"
            };


            Coordinates robotCoordinates = Controller.RobotController(x, y, direction, movements);
            Coordinates expectedCoordinates = new Coordinates()
            {
                Xaxis = 0,
                Yaxis = 0,
                Orientation = "W"
            };

            Assert.AreEqual(robotCoordinates.Orientation, expectedCoordinates.Orientation);
            Assert.AreEqual(robotCoordinates.Xaxis, expectedCoordinates.Xaxis);
            Assert.AreEqual(robotCoordinates.Yaxis, expectedCoordinates.Yaxis);
        }

        [TestMethod]
        public void Should_return_expected_coords_and_orientation_if_movement_is_entered_as_lowercase()
        {
            var x = 10;
            var y = 10;
            var direction = "S";
            List<string> movements = new List<string>()
            {
                "M",
                "M",
                "M",
                "M",
                "M",
                "r",
                "M",
                "M",
                "M",
                "M",
                "M"
            };


            Coordinates robotCoordinates = Controller.RobotController(x, y, direction, movements);
            Coordinates expectedCoordinates = new Coordinates()
            {
                Xaxis = 5,
                Yaxis = 5,
                Orientation = "W"
            };

            Assert.AreEqual(robotCoordinates.Orientation, expectedCoordinates.Orientation);
            Assert.AreEqual(robotCoordinates.Xaxis, expectedCoordinates.Xaxis);
            Assert.AreEqual(robotCoordinates.Yaxis, expectedCoordinates.Yaxis);
        }
    }
}
        