using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotSimulator.Controller
{
    class BoardErrorChecker
    {
        public bool _robotPlaced { get; set; }

        public BoardErrorChecker()
        {
            _robotPlaced = false;
        }
    }
}
