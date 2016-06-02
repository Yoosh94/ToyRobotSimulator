using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobotSimulator.Controller;
using ToyRobotSimulator.Model;

namespace ToyRobotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            RobotController rController = new RobotController();
            BoardErrorChecker boardChecker = new BoardErrorChecker();
            Console.WriteLine("Toy Robot Simulator");
            Console.WriteLine("Enter board height: ");
            int boardHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter board length: ");
            int boardLength = Convert.ToInt32(Console.ReadLine());
            Board board = new Board(boardLength, boardHeight,robot);
            string userInput = "";
            while(userInput != "End")
            {
                userInput = Console.ReadLine();
                //If the robot has not been placed yet we only expect one kind of command
                if(!boardChecker.isRobotPresentOnBoard(board) && !rController.isRobotOnABoard(robot))
                {
                    // If there is a valid command to place the robot
                    if (UserIO.validPlaceCommand(userInput))
                    {
                        string stringWithoutPlace = userInput.Substring(6);
                        string[] commandValues = stringWithoutPlace.Split(',');
                        rController.placeRobotOnBoard(robot, commandValues[0], commandValues[1], commandValues[2]);
                        if (!boardChecker.checkRobot(board))
                        {
                            rController.removeRobotFromBoard(robot);
                        }
                        else
                        {
                            rController.setPreviousLocationAsNewLocation(robot);
                            boardChecker.placeRobotOnBoard(board);
                        }
                    }
                    else
                    {
                        UserIO.showMessage("Robot has not been placed yet. Try 'PLACE 0,0,NORTH'");
                    }
                }
                //Validate if what the user entered is correct at all. If not return an error
                else if (UserIO.validCommand(userInput) && boardChecker.isRobotPresentOnBoard(board) && rController.isRobotOnABoard(robot))
                {
                    //Move the robot                  
                    rController.assignMove(robot,userInput);
                    //If the robot is not in a valid position move it back. If it is in a valid position update the previous position.
                    if (!boardChecker.checkRobot(board))
                    {
                        rController.reverseMove(robot);
                    }
                    else
                    {
                        rController.setPreviousLocationAsNewLocation(robot);
                    }                   
                }
                else
                {
                    UserIO.showMessage("Please enter a valid movement.");
                }
            }
        }
    }
}
