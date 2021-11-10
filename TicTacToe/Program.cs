using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Classes;

namespace TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Game.Run();
        }
    }
}
