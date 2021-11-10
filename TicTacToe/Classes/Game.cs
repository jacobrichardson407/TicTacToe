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

        public static string[] array = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

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
            choice = int.Parse(array[choice]);
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            ConsoleText();
            // call empty board to display
            TTTBoard();
            while (playerOneTurn || playerTwoTurn)
            {
                // if player one's turn, set array choice = user input, set player ones turn to false, set player twos turn to true
                //player one turn
                do
                {
                    Console.WriteLine("                           Player One's turn! Enter a number of where you would like to play!");
                    choice = int.Parse(Console.ReadLine());

                    if (choice == int.Parse("1"))
                    {
                        PlayerMarker();
                        array.SetValue(PlayerOne.PlayerOneIcon(), int.Parse(array[1]));
                        // call console text
                        ConsoleText();
                        TTTBoard();
                        playerOneTurn = false;
                        playerTwoTurn = true;
                    }
                    else if (choice == int.Parse("2"))
                    {
                        PlayerMarker();
                        array.SetValue(PlayerOne.PlayerOneIcon(), int.Parse(array[2]));
                        // call console text
                        ConsoleText();
                        TTTBoard();
                        playerOneTurn = false;
                        playerTwoTurn = true;
                    }

                    else if (choice == int.Parse("3"))
                    {
                        PlayerMarker();
                        array.SetValue(PlayerOne.PlayerOneIcon(), int.Parse(array[3]));
                        // call console text
                        ConsoleText();
                        TTTBoard();
                        playerOneTurn = false;
                        playerTwoTurn = true;
                    }
                    else if (choice == int.Parse("4"))
                    {
                        PlayerMarker();
                        array.SetValue(PlayerOne.PlayerOneIcon(), int.Parse(array[4]));
                        // call console text
                        ConsoleText();
                        TTTBoard();
                        playerOneTurn = false;
                        playerTwoTurn = true;
                    }
                    else if (choice == int.Parse("5"))
                    {
                        PlayerMarker();
                        array.SetValue(PlayerOne.PlayerOneIcon(), int.Parse(array[5]));
                        // call console text
                        ConsoleText();
                        TTTBoard();
                        playerOneTurn = false;
                        playerTwoTurn = true;
                    }
                    else if (choice == int.Parse("6"))
                    {
                        PlayerMarker();
                        array.SetValue(PlayerOne.PlayerOneIcon(), int.Parse(array[6]));
                        // call console text
                        ConsoleText();
                        TTTBoard();
                        playerOneTurn = false;
                        playerTwoTurn = true;
                    }

                    else if (choice == int.Parse("7"))
                    {
                        PlayerMarker();
                        array.SetValue(PlayerOne.PlayerOneIcon(), int.Parse(array[7]));
                        // call console text
                        ConsoleText();
                        TTTBoard();
                        playerOneTurn = false;
                        playerTwoTurn = true;
                    }
                    else if (choice == int.Parse("8"))
                    {
                        PlayerMarker();
                        array.SetValue(PlayerOne.PlayerOneIcon(), int.Parse(array[8]));
                        // call console text
                        ConsoleText();
                        TTTBoard();
                        playerOneTurn = false;
                        playerTwoTurn = true;
                    }
                    else if (choice == int.Parse("9"))
                    {
                        PlayerMarker();
                        array.SetValue(PlayerOne.PlayerOneIcon(), int.Parse(array[9]));
                        // call console text
                        ConsoleText();
                        TTTBoard();
                        playerOneTurn = false;
                        playerTwoTurn = true;
                    }

                } while (playerOneTurn);
                //player 2 turn
                do
                {
                    Console.WriteLine("                           Player Two's turn! Enter a number of where you would like to play!");
                    choice = int.Parse(Console.ReadLine());

                    if (choice == int.Parse("1"))
                    {
                        PlayerMarker();
                        array.SetValue(PlayerTwo.PlayerTwoIcon(), int.Parse(array[1]));
                        // call console text
                        ConsoleText();
                        TTTBoard();
                        playerOneTurn = true;
                        playerTwoTurn = false;
                    }
                    else if (choice == int.Parse("2"))
                    {
                        PlayerMarker();
                        array.SetValue(PlayerTwo.PlayerTwoIcon(), int.Parse(array[2]));
                        // call console text
                        ConsoleText();
                        TTTBoard();
                        playerOneTurn = true;
                        playerTwoTurn = false;
                    }

                    else if (choice == int.Parse("3"))
                    {
                        PlayerMarker();
                        array.SetValue(PlayerTwo.PlayerTwoIcon(), int.Parse(array[3]));
                        // call console text
                        ConsoleText();
                        TTTBoard();
                        playerOneTurn = true;
                        playerTwoTurn = false;
                    }
                    else if (choice == int.Parse("4"))
                    {
                        PlayerMarker();
                        array.SetValue(PlayerTwo.PlayerTwoIcon(), int.Parse(array[4]));
                        // call console text
                        ConsoleText();
                        TTTBoard();
                        playerOneTurn = true;
                        playerTwoTurn = false;
                    }
                    else if (choice == int.Parse("5"))
                    {
                        PlayerMarker();
                        array.SetValue(PlayerTwo.PlayerTwoIcon(), int.Parse(array[5]));
                        // call console text
                        ConsoleText();
                        TTTBoard();
                        playerOneTurn = true;
                        playerTwoTurn = false;
                    }
                    else if (choice == int.Parse("6"))
                    {
                        PlayerMarker();
                        array.SetValue(PlayerTwo.PlayerTwoIcon(), int.Parse(array[6]));
                        // call console text
                        ConsoleText();
                        TTTBoard();
                        playerOneTurn = true;
                        playerTwoTurn = false;
                    }

                    else if (choice == int.Parse("7"))
                    {
                        PlayerMarker();
                        array.SetValue(PlayerTwo.PlayerTwoIcon(), int.Parse(array[7]));
                        // call console text
                        ConsoleText();
                        TTTBoard();
                        playerOneTurn = true;
                        playerTwoTurn = false;
                    }
                    else if (choice == int.Parse("8"))
                    {
                        PlayerMarker();
                        array.SetValue(PlayerTwo.PlayerTwoIcon(), int.Parse(array[8]));
                        // call console text
                        ConsoleText();
                        TTTBoard();
                        playerOneTurn = true;
                        playerTwoTurn = false;
                    }
                    else if (choice == int.Parse("9"))
                    {
                        PlayerMarker();
                        array.SetValue(PlayerTwo.PlayerTwoIcon(), int.Parse(array[9]));
                        // call console text
                        ConsoleText();
                        TTTBoard();
                        playerOneTurn = true;
                        playerTwoTurn = false;
                    }

                } while (playerTwoTurn);
            }

        }

        //board method that creates how board looks
        private static void TTTBoard()
        {
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                                       {array[1]}          |         {array[2]}         |         {array[3]}     ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                               ___________________|___________________|___________________ ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                                       {array[4]}          |         {array[5]}         |         {array[6]}    ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                               ___________________|___________________|___________________ ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                                       {array[7]}          |         {array[8]}         |         {array[9]}    ");
            Console.WriteLine($"                                                  |                   |                    ");
            Console.WriteLine($"                                                  |                   |                    ");
            array[choice] = PlayerMarker();
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
        
        //sets player ones icon to the X marker, sets player twos icon to the O marker
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
            return null;
        }

    }
}
