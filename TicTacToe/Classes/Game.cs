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

        public static int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public static int choice; // this will hold the integer choice that the user inputs

        public static bool playerOneTurn = true;
        public static bool playerTwoTurn = false;

        public static string ticTacToe = @"

            '########:'####::'######:::::'########::::'###:::::'######:::::'########::'#######::'########:
            ... ##..::. ##::'##... ##::::... ##..::::'## ##:::'##... ##::::... ##..::'##.... ##: ##.....::
            ::: ##::::: ##:: ##:::..:::::::: ##:::::'##:. ##:: ##:::..:::::::: ##:::: ##:::: ##: ##:::::::
            ::: ##::::: ##:: ##::::::::::::: ##::::'##:::. ##: ##::::::::::::: ##:::: ##:::: ##: ######:::
            ::: ##::::: ##:: ##::::::::::::: ##:::: #########: ##::::::::::::: ##:::: ##:::: ##: ##...::::
            ::: ##::::: ##:: ##::: ##::::::: ##:::: ##.... ##: ##::: ##::::::: ##:::: ##:::: ##: ##:::::::
            ::: ##::::'####:. ######:::::::: ##:::: ##:::: ##:. ######:::::::: ##::::. #######:: ########:
            :::..:::::....:::......:::::::::..:::::..:::::..:::......:::::::::..::::::.......:::........::

";

        // run everything in here
        public static void Run()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            ConsoleText();
            // call empty board to display
            EmptyBoard();
            // if player one's turn, set array choice = user input, set player ones turn to false, set player twos turn to true

            if (playerOneTurn)
            {
                Console.WriteLine("                           Player One's turn! Enter a number of where you would like to play!");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    // call console text
                    ConsoleText();
                    TTTBoard();
                }
                playerOneTurn = false;
                playerTwoTurn = true;
                if (choice == 2)
                {
                    string output = array[1].ToString();
                    output = PlayerOne.PlayerOneIcon();
                    // call console text
                    ConsoleText();
                    TTTBoard();
                }
                playerOneTurn = false;
                playerTwoTurn = true;
            }
            if (playerTwoTurn)
            {
                Console.WriteLine("                           Player Two's turn! Enter a number of where you would like to play!");
                choice = int.Parse(Console.ReadLine());
            }

        }

        //board method that creates how board looks
        private static void TTTBoard()
        {
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                                       {array[0]}          |         {array[1]}         |         {array[2]}     ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                               ___________________|___________________|___________________ ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                                       {array[3]}          |         {array[4]}         |         {array[5]}    ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                               ___________________|___________________|___________________ ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                                       {array[6]}          |         {array[7]}         |         {array[8]}    ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                                                  |                   |                    ");
            array[choice].ToString(PlayerMarker());
        }
        private static void EmptyBoard()
        {
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                                       {array[0]}          |         {array[1]}         |         {array[2]}     ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                               ___________________|___________________|___________________ ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                                       {array[3]}          |         {array[4]}         |         {array[5]}    ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                               ___________________|___________________|___________________ ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                                       {array[6]}          |         {array[7]}         |         {array[8]}    ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                                                  |                   |                    ");
        }

        // colors the text in the console
        public static void ConsoleText()
        {
            Console.Clear();
            // display: foreach character in the array of the string ticTacToe, if the character is a "#" then the color is red
            // else (if not "#") then the color is blue 
            Char[] array = ticTacToe.ToCharArray();
            foreach (char c in array)
            {
                if (c == '#')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(c);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(c);
                }
            }
        }

        public static string PlayerMarker()
        {
            string marker;
            if (playerOneTurn)
            {
                return marker = PlayerOne.PlayerOneIcon(); ;
            }
            else if (playerTwoTurn)
            {
                return marker = PlayerTwo.PlayerTwoIcon();
            }
            else
            {
                return null;
            }
        }

    }
}
