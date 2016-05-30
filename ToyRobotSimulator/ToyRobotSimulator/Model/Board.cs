using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotSimulator.Model
{
    class Board
    {
        public int _height { get; set; }
        public int _length { get; set; }
        public bool _isRobotPlaced { get; set; }
        public Robot _robot;

        public Board(int length, int height,Robot robot)
        {
            _height = height;
            _length = length;
            _isRobotPlaced = false;
            _robot = robot;
        }
    }
}
