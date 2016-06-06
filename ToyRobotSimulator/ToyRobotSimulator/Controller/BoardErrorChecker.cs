using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobotSimulator.Model;

namespace ToyRobotSimulator.Controller
{
    public class BoardErrorChecker
    {

        public BoardErrorChecker()
        {
        }

        public bool isRobotPresentOnBoard(Board board)
        {
            return board._isRobotPlaced;
        }

        public bool checkRobot(Board board)
        {
            bool isRobotValid = true;
            if(!((board._robot._currentHeightPosition >= 0) && (board._robot._currentHeightPosition <= board._height) && (board._robot._currentLengthPosition >= 0) && (board._robot._currentLengthPosition <= board._length)))
            {
                isRobotValid = false;
            }
            return isRobotValid;
        }

        public void placeRobotOnBoard(Board board)
        {
            board._isRobotPlaced = true;
        }
    }
}
