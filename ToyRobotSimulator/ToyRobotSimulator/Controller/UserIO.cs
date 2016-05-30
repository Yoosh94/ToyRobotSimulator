using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotSimulator.Controller
{
    static class UserIO
    {
        private enum allowedCommands {PLACE,MOVE,LEFT,RIGHT,REPORT};
        public static bool validCommand(string command)
        {
            bool validCommand = false;
            if (Enum.IsDefined(typeof(allowedCommands), command))
            {
                validCommand = true;
            }
            return validCommand;
        }

        public static void showMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
