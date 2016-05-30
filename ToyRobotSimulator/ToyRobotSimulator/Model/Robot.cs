using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotSimulator.Model
{
    class Robot
    {
        public enum Direction { NORTH,EAST,SOUTH,WEST}
        public bool _isRobotPlaced { get; set; }
        public int _currentHeightPosition { get; set; }
        public int _currentLengthPosition { get; set; }
        public Direction directionFacing;
        public Robot()
        {
            //Empty constructor
            
        }

        public override string ToString()
        {
            return "OUTPUT: " + _currentLengthPosition + "," + _currentHeightPosition + "," + directionFacing.ToString();
        }
    }
}
