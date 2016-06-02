using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobotSimulator.Model;

namespace ToyRobotSimulator.Controller
{
    class RobotController
    {
        public RobotController()
        {
            //Empty constructor
        }

        public void assignMove(Robot robot, string userInput)
        {
            switch (userInput)
            {
                case "MOVE":
                    moveRobot(robot);
                    break;
                case "LEFT":
                    turnRobotCCW(robot);
                    break;
                case "RIGHT":
                    turnRobotCW(robot);
                    break;
                case "REPORT":
                    UserIO.showMessage(robot.ToString());
                    break;
               
            }
        }

        private void moveRobot(Robot robot)
        {
            Robot.Direction directionOfRobot = robot.directionFacing;
            switch (directionOfRobot)
            {
                case Robot.Direction.NORTH:
                    robot._currentHeightPosition = robot._currentHeightPosition + 1;
                    break;
                case Robot.Direction.EAST:
                    robot._currentLengthPosition = robot._currentLengthPosition + 1;
                    break;
                case Robot.Direction.SOUTH:
                    robot._currentHeightPosition = robot._currentHeightPosition - 1;
                    break;
                case Robot.Direction.WEST:
                    robot._currentLengthPosition = robot._currentLengthPosition - 1;
                    break;
            }
        }

        private void turnRobotCCW(Robot robot)
        {
            switch (robot.directionFacing)
            {
                case Robot.Direction.NORTH:
                    robot.directionFacing = Robot.Direction.WEST;
                    break;
                case Robot.Direction.EAST:
                    robot.directionFacing = Robot.Direction.NORTH;
                    break;
                case Robot.Direction.SOUTH:
                    robot.directionFacing = Robot.Direction.EAST;
                    break;
                case Robot.Direction.WEST:
                    robot.directionFacing = Robot.Direction.SOUTH;
                    break;
            }
        }

        private void turnRobotCW(Robot robot)
        {
            switch (robot.directionFacing)
            {
                case Robot.Direction.NORTH:
                    robot.directionFacing = Robot.Direction.EAST;
                    break;
                case Robot.Direction.EAST:
                    robot.directionFacing = Robot.Direction.SOUTH;
                    break;
                case Robot.Direction.SOUTH:
                    robot.directionFacing = Robot.Direction.WEST;
                    break;
                case Robot.Direction.WEST:
                    robot.directionFacing = Robot.Direction.NORTH;
                    break;
            }
        }

        public void reverseMove(Robot robot)
        {
            robot._currentHeightPosition = robot._previousHeightPosition;
            robot._currentLengthPosition = robot._previousLengthPosition;
            robot.directionFacing = robot.previousDirectionFacing;
        }

        public void setPreviousLocationAsNewLocation(Robot robot)
        {
            robot._previousHeightPosition = robot._currentHeightPosition;
            robot._previousLengthPosition = robot._currentLengthPosition;
            robot.previousDirectionFacing = robot.directionFacing;
        }

        public bool isRobotOnABoard(Robot robot)
        {
            return robot._isRobotPlaced;
        }
        
        public void placeRobotOnBoard(Robot robot, string xCoord, string yCoord, string direction)
        {
            robot._currentHeightPosition = Convert.ToInt32(yCoord);
            robot._currentLengthPosition = Convert.ToInt32(xCoord);
            Robot.Direction di = (Robot.Direction) Enum.Parse(typeof(Robot.Direction), direction);
            robot.directionFacing = di;
            robot._isRobotPlaced = true;
        }

        public void removeRobotFromBoard(Robot robot)
        {
            robot._isRobotPlaced = false;
        }
    }
}
