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
            robot._currentHeightPosition = 0;
            robot._currentLengthPosition = 0;
            robot.directionFacing = Robot.Direction.NORTH;
            robot._isRobotPlaced = true;
            RobotController rController = new RobotController();
            BoardErrorChecker boardChecker = new BoardErrorChecker();
            Console.WriteLine("Toy Robot Simulator");
            Console.WriteLine("Enter board height: ");
            int boardHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter board length: ");
            int boardLength = Convert.ToInt32(Console.ReadLine());
            Board board = new Board(boardLength, boardHeight,robot);
            board._isRobotPlaced = true;
            string userInput = "";
            while(userInput != "End")
            {
                userInput = Console.ReadLine();
                //Validate if what the user entered is correct at all. If not return an error
                if (UserIO.validCommand(userInput))
                {
                    //check if the robot has been placed on the baord already
                    if (boardChecker.isRobotPresentOnBoard(board) && rController.isRobotOnABoard(robot))
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
                    
                }
                else
                {
                    UserIO.showMessage("Please enter a valid movement.");
                }
                

                
            }

        }
    }
}
