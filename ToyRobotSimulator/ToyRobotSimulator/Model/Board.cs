using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotSimulator.Model
{
    class Board
    {
        private int _height { get; set; }
        private int _length { get; set; }
        public bool _isRobotPlaced { get; set; }

        public Board(int length, int height)
        {
            _height = height;
            _length = length;
            _isRobotPlaced = false;
        }
    }
}
