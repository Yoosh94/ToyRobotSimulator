using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotSimulator.Model
{
   public class Robot
    {
        public enum Direction { NORTH,EAST,SOUTH,WEST}
        public bool _isRobotPlaced;
        public int _currentHeightPosition;
        public int _currentLengthPosition;
        public int _previousHeightPosition;
        public int _previousLengthPosition;
        public Direction directionFacing;
        public Direction previousDirectionFacing;
        public Robot()
        {
            _isRobotPlaced = false;
            
        }

        public override string ToString()
        {
            return "OUTPUT: " + _currentLengthPosition + "," + _currentHeightPosition + "," + directionFacing.ToString();
        }
    }
}
