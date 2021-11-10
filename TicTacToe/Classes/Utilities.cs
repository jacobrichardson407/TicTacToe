using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Classes
{
    public static class Utilities
    {
        public static string ChangeColor(string value, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            return value;
        }
    }
}
