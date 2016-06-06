using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobotSimulator.Controller;
using ToyRobotSimulator.Model;

namespace TestRobot
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void isRobotPresentOnBoard_equalfalse_duringInit()
        {
            int length = 5;
            int height = 5;
            Robot robot = new Robot();
            Board board = new Board(length, height, robot);
            Assert.IsFalse(board._isRobotPlaced);
        }

        #region Check if the robot is in a valid location or not
        [TestMethod]
        public void checkValidRobot_onBoard()
        {
            BoardErrorChecker BEC = new BoardErrorChecker();
            //Create Valid Robot with valid Position
            Robot robot = new Robot();
            robot._currentHeightPosition = 2;
            robot._currentLengthPosition = 2;
            Board board = new Board(5, 5, robot);
            Assert.IsTrue(BEC.checkRobot(board));
        }

        [TestMethod]
        public void checkInValidRobot_onBoard()
        {
            BoardErrorChecker BEC = new BoardErrorChecker();
            //Create Valid Robot with valid Position
            Robot robot = new Robot();
            robot._currentHeightPosition = 10;
            robot._currentLengthPosition = 10;
            Board board = new Board(5, 5, robot);
            Assert.IsFalse(BEC.checkRobot(board));
        }

        #endregion
    }
}
