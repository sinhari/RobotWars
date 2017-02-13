using System.Collections.Generic;
using RobotWars.Business.Model;

namespace RobotWars.Business
{
    public class Controller
    {
        public static Coordinates RobotController(int x, int y, string direction, List<string> movements)
        {
            Coordinates robotCoordinates = new Coordinates
            {
                Xaxis = x,
                Yaxis = y,
                Orientation = direction.ToUpper()
            };

            movements = movements.ConvertAll(d => d.ToUpper());
            robotCoordinates = ProcessRobotMovement(robotCoordinates, movements);
            return robotCoordinates;
        }

        private static Coordinates ProcessRobotMovement(Coordinates existingcoordinates, List<string> movements)
        {
            var alteredCoordinates = new Coordinates();

            foreach (var move in movements)
                if (move == "M")
                {
                    alteredCoordinates = SetCoordinates(existingcoordinates);
                }
                else
                {
                    alteredCoordinates.Orientation = SetDirection(move, existingcoordinates.Orientation);
                    existingcoordinates.Orientation = alteredCoordinates.Orientation;
                }
            return alteredCoordinates;
        }

        private static string SetDirection(string move, string direction)
        {
            string altereddirection = "";
            if (move == "L")
            {
                altereddirection = MoveLeft(direction);
            }
            else if (move == "R")
            {
                altereddirection = MoveRight(direction);
            }
            return altereddirection;
        }

        private static string MoveRight(string direction)
        {
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;
                case "E":
                    direction = "S";
                    break;
                case "S":
                    direction = "W";
                    break;
                case "W":
                    direction = "N";
                    break;
            }
            return direction;
        }

        private static string MoveLeft(string direction)
        {
            switch (direction)
            {
                case "N":
                    direction = "W";
                    break;
                case "W":
                    direction = "S";
                    break;
                case "S":
                    direction = "E";
                    break;
                case "E":
                    direction = "N";
                    break;
            }
            return direction;
        }


        private static Coordinates SetCoordinates(Coordinates existingcoordinates)
        {
            if (existingcoordinates.Orientation == "N")
            {
                existingcoordinates.Yaxis = existingcoordinates.Yaxis + 1;
            }
            else if (existingcoordinates.Orientation == "S")
            {
                existingcoordinates.Yaxis = existingcoordinates.Yaxis - 1;
            }
            else if (existingcoordinates.Orientation == "E")
            {
                existingcoordinates.Xaxis = existingcoordinates.Xaxis + 1;
            }
            else if (existingcoordinates.Orientation == "W")
            {
                existingcoordinates.Xaxis = existingcoordinates.Xaxis - 1;
            }
            Coordinates changedCoordinates = new Coordinates
            {
                Xaxis = existingcoordinates.Xaxis,
                Yaxis = existingcoordinates.Yaxis,
                Orientation = existingcoordinates.Orientation
            };
            return changedCoordinates;
        }
    }
    
}
