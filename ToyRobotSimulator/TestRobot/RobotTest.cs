using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobotSimulator.Controller;
using ToyRobotSimulator.Model;

namespace TestRobot
{
    /// <summary>
    /// Summary description for RobotTest
    /// </summary>
    [TestClass]
    public class RobotTest
    {
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
        #region Move Left Valid
        [TestMethod]
        public void assignMove_Left_NORTHTOWEST()
        {
            string move = "LEFT";
            Robot robot = new Robot();
            robot.directionFacing = Robot.Direction.NORTH;
            RobotController RC = new RobotController();
            RC.assignMove(robot, move);
            Assert.AreEqual(Robot.Direction.WEST, robot.directionFacing);
        }

        [TestMethod]
        public void assignMove_Left_WESTTOSOUTH()
        {
            string move = "LEFT";
            Robot robot = new Robot();
            robot.directionFacing = Robot.Direction.WEST;
            RobotController RC = new RobotController();
            RC.assignMove(robot, move);
            Assert.AreEqual(Robot.Direction.SOUTH, robot.directionFacing);
        }

        [TestMethod]
        public void assignMove_Left_SOUTHTOEAST()
        {
            string move = "LEFT";
            Robot robot = new Robot();
            robot.directionFacing = Robot.Direction.SOUTH;
            RobotController RC = new RobotController();
            RC.assignMove(robot, move);
            Assert.AreEqual(Robot.Direction.EAST, robot.directionFacing);
        }

        [TestMethod]
        public void assignMove_Left_EASTTONORTH()
        {
            string move = "LEFT";
            Robot robot = new Robot();
            robot.directionFacing = Robot.Direction.EAST;
            RobotController RC = new RobotController();
            RC.assignMove(robot, move);
            Assert.AreEqual(Robot.Direction.NORTH, robot.directionFacing);
        }

        #endregion

        #region Move Right Valid
        [TestMethod]
        public void assignMove_RIGHT_NORTHTOEAST()
        {
            string move = "RIGHT";
            Robot robot = new Robot();
            robot.directionFacing = Robot.Direction.NORTH;
            RobotController RC = new RobotController();
            RC.assignMove(robot, move);
            Assert.AreEqual(Robot.Direction.EAST, robot.directionFacing);
        }

        [TestMethod]
        public void assignMove_Right_EASTTOSOUTH()
        {
            string move = "RIGHT";
            Robot robot = new Robot();
            robot.directionFacing = Robot.Direction.EAST;
            RobotController RC = new RobotController();
            RC.assignMove(robot, move);
            Assert.AreEqual(Robot.Direction.SOUTH, robot.directionFacing);
        }

        [TestMethod]
        public void assignMove_Right_SOUTHTOWEST()
        {
            string move = "RIGHT";
            Robot robot = new Robot();
            robot.directionFacing = Robot.Direction.SOUTH;
            RobotController RC = new RobotController();
            RC.assignMove(robot, move);
            Assert.AreEqual(Robot.Direction.WEST, robot.directionFacing);
        }

        [TestMethod]
        public void assignMove_Right_WESTTONORTH()
        {
            string move = "RIGHT";
            Robot robot = new Robot();
            robot.directionFacing = Robot.Direction.WEST;
            RobotController RC = new RobotController();
            RC.assignMove(robot, move);
            Assert.AreEqual(Robot.Direction.NORTH, robot.directionFacing);
        }

        #endregion
        #region Move Forward Valid
        [TestMethod]
        public void assignMove_MOVE_NORTH()
        {
            string move = "MOVE";
            Robot robot = new Robot();
            robot.directionFacing = Robot.Direction.NORTH;
            robot._currentHeightPosition = 0;
            robot._currentLengthPosition = 0;
            RobotController RC = new RobotController();
            RC.assignMove(robot, move);
            Assert.AreEqual(1, robot._currentHeightPosition);
        }

        [TestMethod]
        public void assignMove_MOVE_EAST()
        {
            string move = "MOVE";
            Robot robot = new Robot();
            robot.directionFacing = Robot.Direction.EAST;
            robot._currentHeightPosition = 0;
            robot._currentLengthPosition = 0;
            RobotController RC = new RobotController();
            RC.assignMove(robot, move);
            Assert.AreEqual(1, robot._currentLengthPosition);
        }

        [TestMethod]
        public void assignMove_MOVE_SOUTH()
        {
            string move = "MOVE";
            Robot robot = new Robot();
            robot.directionFacing = Robot.Direction.SOUTH;
            robot._currentHeightPosition = 5;
            robot._currentLengthPosition = 0;
            RobotController RC = new RobotController();
            RC.assignMove(robot, move);
            Assert.AreEqual(4, robot._currentHeightPosition);
        }

        [TestMethod]
        public void assignMove_MOVE_WEST()
        {
            string move = "MOVE";
            Robot robot = new Robot();
            robot.directionFacing = Robot.Direction.WEST;
            robot._currentHeightPosition = 0;
            robot._currentLengthPosition = 5;
            RobotController RC = new RobotController();
            RC.assignMove(robot, move);
            Assert.AreEqual(4, robot._currentLengthPosition);
        }
        #endregion
    }
}
