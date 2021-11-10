using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Classes
{
    public class Game
    {
        //making array and   

        //by default I am providing 0-9 where no use of zero  

        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static int player = 1; //By default player 1 is set  

        static int choice; //This holds the choice at which position user want to mark   

        static bool playerOneTurn = true;
        static bool playerTwoTurn = false;



        // The flag veriable checks who has won if it's value is 1 then some one has won the match if -1 then Match has Draw if 0 then match is still running  

        static int flag = 0;
        public static void Run()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;

            string ticTacToe = @"

            '########:'####::'######:::::'########::::'###:::::'######:::::'########::'#######::'########:
            ... ##..::. ##::'##... ##::::... ##..::::'## ##:::'##... ##::::... ##..::'##.... ##: ##.....::
            ::: ##::::: ##:: ##:::..:::::::: ##:::::'##:. ##:: ##:::..:::::::: ##:::: ##:::: ##: ##:::::::
            ::: ##::::: ##:: ##::::::::::::: ##::::'##:::. ##: ##::::::::::::: ##:::: ##:::: ##: ######:::
            ::: ##::::: ##:: ##::::::::::::: ##:::: #########: ##::::::::::::: ##:::: ##:::: ##: ##...::::
            ::: ##::::: ##:: ##::: ##::::::: ##:::: ##.... ##: ##::: ##::::::: ##:::: ##:::: ##: ##:::::::
            ::: ##::::'####:. ######:::::::: ##:::: ##:::: ##:. ######:::::::: ##::::. #######:: ########:
            :::..:::::....:::......:::::::::..:::::..:::::..:::......:::::::::..::::::.......:::........::

";
            Console.WriteLine(ticTacToe);


            TTTBoard();
            Console.WriteLine("Player One's turn! Enter a number of where you would like to play!");
            choice = Convert.ToInt32(Console.ReadLine());

            if (playerOneTurn)
            {


            }

            Console.ReadKey();
        }

        public static void TTTBoard()

        {

            Console.WriteLine("             |             |              ");

            Console.WriteLine("      {0}      |      {1}      |      {2}", arr[1], arr[2], arr[3]);

            Console.WriteLine("_____________|_____________|_____________ ");

            Console.WriteLine("             |             |              ");

            Console.WriteLine("      {0}      |      {1}      |      {2}", arr[4], arr[5], arr[6]);

            Console.WriteLine("_____________|_____________|_____________ ");

            Console.WriteLine("             |             |              ");

            Console.WriteLine("      {0}      |      {1}      |      {2}", arr[7], arr[8], arr[9]);

            Console.WriteLine("             |             |              ");

        }

        public static void Player_One_Icon()
        {
            string x = @"


               __   __
               \ \ / /
                \ V / 
                 > <  
                / . \ 
               /_/ \_\

";
            Console.WriteLine(x);
        }

        public void Player_Two_Icon()
        {
            string o = @"



                ____  
               / __ \ 
              | |  | |
              | |  | |
              | |__| |
               \____/ 

";

            Console.WriteLine(o);

        }

    }
}
