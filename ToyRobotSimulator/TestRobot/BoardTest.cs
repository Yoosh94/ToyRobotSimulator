using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobotSimulator.Controller;
using ToyRobotSimulator.Model;

namespace TestRobot
{
    [TestClass]
    public class BoardTest
    {
        #region check if the Robot has been placed on the board or not
        [TestMethod]
        public void isRobotPresentOnBoard_valid()
        {
            BoardErrorChecker BEC = new BoardErrorChecker();
            int length = 5;
            int height = 5;
            Robot robot = new Robot();
            Board board = new Board(length, height, robot);
            BEC.placeRobotOnBoard(board);
            Assert.IsTrue(BEC.isRobotPresentOnBoard(board));
            
        }
        [TestMethod]
        public void isRobotPresentOnBoard_invalid()
        {
            BoardErrorChecker BEC = new BoardErrorChecker();
            int length = 5;
            int height = 5;
            Robot robot = new Robot();
            Board board = new Board(length, height, robot);
            Assert.IsFalse(BEC.isRobotPresentOnBoard(board));

        }
        #endregion
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
