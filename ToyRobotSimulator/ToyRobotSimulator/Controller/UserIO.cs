using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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

        public static bool validPlaceCommand(string command)
        {
            bool validPlaceCommand = false;
            command.Trim();
            Regex validPlaceRegex = new Regex(@"^(PLACE)\s\d,\d,(NORTH)|(SOUTH)|(EAST)|(WEST)$");
            Match matchPlaceRegex = validPlaceRegex.Match(command);
            if (matchPlaceRegex.Success)
            {
                validPlaceCommand = true;
            }
            return validPlaceCommand;
        }

        public static void showMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
