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
            Console.WriteLine("Enter board height: ");
            int boardHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter board length: ");
            int boardLength = Convert.ToInt32(Console.ReadLine());
            Board board = new Board(boardLength, boardHeight);

            string userInput = "";
            Console.WriteLine("Toy Robot Simulator");
            Robot robot = new Robot();
            RobotController rController = new RobotController();
            BoardErrorChecker boardChecker = new BoardErrorChecker();
            while(userInput != "End")
            {
                userInput = Console.ReadLine();
                //Validate if what the user entered is correct at all. If not return an error
                if (UserIO.validCommand(userInput))
                {
                    //check if the robot has been placed on the baord already
                    if (boardChecker.isRobotPresentOnBoard(board) && rController.isRobotOnABoard(robot))
                    {
                        rController.assignMove(robot,userInput);
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
