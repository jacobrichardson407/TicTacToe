using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TicTacToe.Classes
{
    public class Game
    {
        //making array and    

        public static string[] array = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public static int choice; // this will hold the integer choice that the user inputs
        public static int turns = 0;

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
            array = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            choice = int.Parse(array[choice]);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
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
                    GameWinner();
                    turns++;
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
                    GameWinner();
                    turns++;
                } while (playerTwoTurn);
            }

        }

        //board method that creates how board looks
        private static void TTTBoard()
        {
            string board = $@"
                               ___________________________________________________________ 
                              |                   |                   |                   | 
                              |                   |                   |                   | 
                              |         {array[1]}         |         {array[2]}         |         {array[3]}         |   
                              |                   |                   |                   |
                              |___________________|___________________|___________________| 
                              |                   |                   |                   | 
                              |                   |                   |                   | 
                              |         {array[4]}         |         {array[5]}         |         {array[6]}         |
                              |                   |                   |                   | 
                              |___________________|___________________|___________________| 
                              |                   |                   |                   | 
                              |                   |                   |                   | 
                              |         {array[7]}         |         {array[8]}         |         {array[9]}         |
                              |                   |                   |                   | 
                              |___________________|___________________|___________________| ";
            Console.WriteLine(board);

            array[choice] = PlayerMarker();
        }

        public static void GameWinner()
        {
            //top row check
            if (array[1].Contains(PlayerOne.PlayerOneIcon()) && array[2].Contains(PlayerOne.PlayerOneIcon()) && array[3].Contains(PlayerOne.PlayerOneIcon()))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                string winner = @"
                                                   Player One Wins!!!
                                    __          _______ _   _ _   _ ______ _____  
                                    \ \        / /_   _| \ | | \ | |  ____|  __ \ 
                                     \ \  /\  / /  | | |  \| |  \| | |__  | |__) |
                                      \ \/  \/ /   | | | . ` | . ` |  __| |  _  / 
                                       \  /\  /   _| |_| |\  | |\  | |____| | \ \ 
                                        \/  \/   |_____|_| \_|_| \_|______|_|  \_\";
                Console.WriteLine(winner);
                TTTBoard();
                //NewGame();
            }
            else if (array[1].Contains(PlayerTwo.PlayerTwoIcon()) && array[2].Contains(PlayerTwo.PlayerTwoIcon()) && array[3].Contains(PlayerTwo.PlayerTwoIcon()))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                string winner = @"
                                                   Player Two Wins!!!
                                    __          _______ _   _ _   _ ______ _____  
                                    \ \        / /_   _| \ | | \ | |  ____|  __ \ 
                                     \ \  /\  / /  | | |  \| |  \| | |__  | |__) |
                                      \ \/  \/ /   | | | . ` | . ` |  __| |  _  / 
                                       \  /\  /   _| |_| |\  | |\  | |____| | \ \ 
                                        \/  \/   |_____|_| \_|_| \_|______|_|  \_\";
                Console.WriteLine(winner);
                TTTBoard();
                //NewGame();
            }
            // middle row check
            if (array[4].Contains(PlayerOne.PlayerOneIcon()) && array[5].Contains(PlayerOne.PlayerOneIcon()) && array[6].Contains(PlayerOne.PlayerOneIcon()))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                string winner = @"
                                                   Player One Wins!!!
                                    __          _______ _   _ _   _ ______ _____  
                                    \ \        / /_   _| \ | | \ | |  ____|  __ \ 
                                     \ \  /\  / /  | | |  \| |  \| | |__  | |__) |
                                      \ \/  \/ /   | | | . ` | . ` |  __| |  _  / 
                                       \  /\  /   _| |_| |\  | |\  | |____| | \ \ 
                                        \/  \/   |_____|_| \_|_| \_|______|_|  \_\";
                Console.WriteLine(winner);
                TTTBoard();
                //NewGame();
            }
            else if (array[4].Contains(PlayerTwo.PlayerTwoIcon()) && array[5].Contains(PlayerTwo.PlayerTwoIcon()) && array[6].Contains(PlayerTwo.PlayerTwoIcon()))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                string winner = @"
                                                   Player Two Wins!!!
                                    __          _______ _   _ _   _ ______ _____  
                                    \ \        / /_   _| \ | | \ | |  ____|  __ \ 
                                     \ \  /\  / /  | | |  \| |  \| | |__  | |__) |
                                      \ \/  \/ /   | | | . ` | . ` |  __| |  _  / 
                                       \  /\  /   _| |_| |\  | |\  | |____| | \ \ 
                                        \/  \/   |_____|_| \_|_| \_|______|_|  \_\";
                Console.WriteLine(winner);
                TTTBoard();
                //NewGame();
            }
            //bottom row check
            if (array[7].Contains(PlayerOne.PlayerOneIcon()) && array[8].Contains(PlayerOne.PlayerOneIcon()) && array[9].Contains(PlayerOne.PlayerOneIcon()))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                string winner = @"
                                                   Player One Wins!!!
                                    __          _______ _   _ _   _ ______ _____  
                                    \ \        / /_   _| \ | | \ | |  ____|  __ \ 
                                     \ \  /\  / /  | | |  \| |  \| | |__  | |__) |
                                      \ \/  \/ /   | | | . ` | . ` |  __| |  _  / 
                                       \  /\  /   _| |_| |\  | |\  | |____| | \ \ 
                                        \/  \/   |_____|_| \_|_| \_|______|_|  \_\";
                Console.WriteLine(winner);
                TTTBoard();
                //NewGame();
            }
            else if (array[7].Contains(PlayerTwo.PlayerTwoIcon()) && array[8].Contains(PlayerTwo.PlayerTwoIcon()) && array[9].Contains(PlayerTwo.PlayerTwoIcon()))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                string winner = @"
                                                   Player Two Wins!!!
                                    __          _______ _   _ _   _ ______ _____  
                                    \ \        / /_   _| \ | | \ | |  ____|  __ \ 
                                     \ \  /\  / /  | | |  \| |  \| | |__  | |__) |
                                      \ \/  \/ /   | | | . ` | . ` |  __| |  _  / 
                                       \  /\  /   _| |_| |\  | |\  | |____| | \ \ 
                                        \/  \/   |_____|_| \_|_| \_|______|_|  \_\";
                Console.WriteLine(winner);
                TTTBoard();
                //NewGame();
            }
            //left coloumn check
            if (array[1].Contains(PlayerOne.PlayerOneIcon()) && array[4].Contains(PlayerOne.PlayerOneIcon()) && array[7].Contains(PlayerOne.PlayerOneIcon()))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                string winner = @"
                                                   Player One Wins!!!
                                    __          _______ _   _ _   _ ______ _____  
                                    \ \        / /_   _| \ | | \ | |  ____|  __ \ 
                                     \ \  /\  / /  | | |  \| |  \| | |__  | |__) |
                                      \ \/  \/ /   | | | . ` | . ` |  __| |  _  / 
                                       \  /\  /   _| |_| |\  | |\  | |____| | \ \ 
                                        \/  \/   |_____|_| \_|_| \_|______|_|  \_\";
                Console.WriteLine(winner);
                TTTBoard();
                //NewGame();
            }
            else if (array[1].Contains(PlayerTwo.PlayerTwoIcon()) && array[4].Contains(PlayerTwo.PlayerTwoIcon()) && array[7].Contains(PlayerTwo.PlayerTwoIcon()))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                string winner = @"
                                                   Player Two Wins!!!
                                    __          _______ _   _ _   _ ______ _____  
                                    \ \        / /_   _| \ | | \ | |  ____|  __ \ 
                                     \ \  /\  / /  | | |  \| |  \| | |__  | |__) |
                                      \ \/  \/ /   | | | . ` | . ` |  __| |  _  / 
                                       \  /\  /   _| |_| |\  | |\  | |____| | \ \ 
                                        \/  \/   |_____|_| \_|_| \_|______|_|  \_\";
                Console.WriteLine(winner);
                TTTBoard();
                //NewGame();
            }
            //middle column check
            if (array[2].Contains(PlayerOne.PlayerOneIcon()) && array[5].Contains(PlayerOne.PlayerOneIcon()) && array[8].Contains(PlayerOne.PlayerOneIcon()))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                string winner = @"
                                                   Player One Wins!!!
                                    __          _______ _   _ _   _ ______ _____  
                                    \ \        / /_   _| \ | | \ | |  ____|  __ \ 
                                     \ \  /\  / /  | | |  \| |  \| | |__  | |__) |
                                      \ \/  \/ /   | | | . ` | . ` |  __| |  _  / 
                                       \  /\  /   _| |_| |\  | |\  | |____| | \ \ 
                                        \/  \/   |_____|_| \_|_| \_|______|_|  \_\";
                Console.WriteLine(winner);
                TTTBoard();
                //NewGame();
            }
            else if (array[2].Contains(PlayerTwo.PlayerTwoIcon()) && array[5].Contains(PlayerTwo.PlayerTwoIcon()) && array[8].Contains(PlayerTwo.PlayerTwoIcon()))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                string winner = @"
                                                   Player Two Wins!!!
                                    __          _______ _   _ _   _ ______ _____  
                                    \ \        / /_   _| \ | | \ | |  ____|  __ \ 
                                     \ \  /\  / /  | | |  \| |  \| | |__  | |__) |
                                      \ \/  \/ /   | | | . ` | . ` |  __| |  _  / 
                                       \  /\  /   _| |_| |\  | |\  | |____| | \ \ 
                                        \/  \/   |_____|_| \_|_| \_|______|_|  \_\";
                Console.WriteLine(winner);
                TTTBoard();
            }
            //right column check
            if (array[3].Contains(PlayerOne.PlayerOneIcon()) && array[6].Contains(PlayerOne.PlayerOneIcon()) && array[9].Contains(PlayerOne.PlayerOneIcon()))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                string winner = @"
                                                   Player One Wins!!!
                                    __          _______ _   _ _   _ ______ _____  
                                    \ \        / /_   _| \ | | \ | |  ____|  __ \ 
                                     \ \  /\  / /  | | |  \| |  \| | |__  | |__) |
                                      \ \/  \/ /   | | | . ` | . ` |  __| |  _  / 
                                       \  /\  /   _| |_| |\  | |\  | |____| | \ \ 
                                        \/  \/   |_____|_| \_|_| \_|______|_|  \_\";
                Console.WriteLine(winner);
                TTTBoard();
                //NewGame();
            }
            else if (array[3].Contains(PlayerTwo.PlayerTwoIcon()) && array[6].Contains(PlayerTwo.PlayerTwoIcon()) && array[9].Contains(PlayerTwo.PlayerTwoIcon()))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                string winner = @"
                                                   Player Two Wins!!!
                                    __          _______ _   _ _   _ ______ _____  
                                    \ \        / /_   _| \ | | \ | |  ____|  __ \ 
                                     \ \  /\  / /  | | |  \| |  \| | |__  | |__) |
                                      \ \/  \/ /   | | | . ` | . ` |  __| |  _  / 
                                       \  /\  /   _| |_| |\  | |\  | |____| | \ \ 
                                        \/  \/   |_____|_| \_|_| \_|______|_|  \_\";
                Console.WriteLine(winner);
                TTTBoard();
                //NewGame();
            }
            //Top left diagonal
            if (array[1].Contains(PlayerOne.PlayerOneIcon()) && array[5].Contains(PlayerOne.PlayerOneIcon()) && array[9].Contains(PlayerOne.PlayerOneIcon()))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                string winner = @"
                                                   Player One Wins!!!
                                    __          _______ _   _ _   _ ______ _____  
                                    \ \        / /_   _| \ | | \ | |  ____|  __ \ 
                                     \ \  /\  / /  | | |  \| |  \| | |__  | |__) |
                                      \ \/  \/ /   | | | . ` | . ` |  __| |  _  / 
                                       \  /\  /   _| |_| |\  | |\  | |____| | \ \ 
                                        \/  \/   |_____|_| \_|_| \_|______|_|  \_\";
                Console.WriteLine(winner);
                TTTBoard();
                //NewGame();
            }
            else if (array[1].Contains(PlayerTwo.PlayerTwoIcon()) && array[5].Contains(PlayerTwo.PlayerTwoIcon()) && array[9].Contains(PlayerTwo.PlayerTwoIcon()))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                string winner = @"
                                                   Player Two Wins!!!
                                    __          _______ _   _ _   _ ______ _____  
                                    \ \        / /_   _| \ | | \ | |  ____|  __ \ 
                                     \ \  /\  / /  | | |  \| |  \| | |__  | |__) |
                                      \ \/  \/ /   | | | . ` | . ` |  __| |  _  / 
                                       \  /\  /   _| |_| |\  | |\  | |____| | \ \ 
                                        \/  \/   |_____|_| \_|_| \_|______|_|  \_\";
                Console.WriteLine(winner);
                TTTBoard();
                //NewGame();
            }
            //Top right diagonal
            if (array[3].Contains(PlayerOne.PlayerOneIcon()) && array[5].Contains(PlayerOne.PlayerOneIcon()) && array[7].Contains(PlayerOne.PlayerOneIcon()))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                string winner = @"
                                                   Player One Wins!!!
                                    __          _______ _   _ _   _ ______ _____  
                                    \ \        / /_   _| \ | | \ | |  ____|  __ \ 
                                     \ \  /\  / /  | | |  \| |  \| | |__  | |__) |
                                      \ \/  \/ /   | | | . ` | . ` |  __| |  _  / 
                                       \  /\  /   _| |_| |\  | |\  | |____| | \ \ 
                                        \/  \/   |_____|_| \_|_| \_|______|_|  \_\";
                Console.WriteLine(winner);
                TTTBoard();
                //NewGame();
            }
            else if (array[3].Contains(PlayerTwo.PlayerTwoIcon()) && array[5].Contains(PlayerTwo.PlayerTwoIcon()) && array[7].Contains(PlayerTwo.PlayerTwoIcon()))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                string winner = @"
                                                   Player Two Wins!!!
                                    __          _______ _   _ _   _ ______ _____  
                                    \ \        / /_   _| \ | | \ | |  ____|  __ \ 
                                     \ \  /\  / /  | | |  \| |  \| | |__  | |__) |
                                      \ \/  \/ /   | | | . ` | . ` |  __| |  _  / 
                                       \  /\  /   _| |_| |\  | |\  | |____| | \ \ 
                                        \/  \/   |_____|_| \_|_| \_|______|_|  \_\";
                Console.WriteLine(winner);
                TTTBoard();
                //NewGame();
            }
            else if (turns == 8)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                string draw = @"
                                                       The game is a:
                                               _____  _____       __          __
                                              |  __ \|  __ \     /\ \        / /
                                              | |  | | |__) |   /  \ \  /\  / / 
                                              | |  | |  _  /   / /\ \ \/  \/ /  
                                              | |__| | | \ \  / ____ \  /\  /   
                                              |_____/|_|  \_\/_/    \_\/  \/";
                Console.WriteLine(draw);
                TTTBoard();
                //NewGame();
            }
            return;
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
            while (playerOneTurn)
            {
                return marker = PlayerOne.PlayerOneIcon();
            }

            while (playerTwoTurn)
            {
                return marker = PlayerTwo.PlayerTwoIcon();
            }
            return null;
        }

        //public static void NewGame()
        //{
        //    Console.WriteLine(
        //        "\n" +
        //        "\n" +
        //        "\n");
        //    Console.WriteLine("                                            Would you like to start a new game???");
        //    Console.WriteLine("                                                       Type yes or no!");
        //    Console.WriteLine(
        //        "\n" +
        //        "\n" +
        //        "\n");
        //    string newGame = Console.ReadLine();
        //    if (newGame == "yes" || newGame == "Yes")
        //    {
        //        Run();
        //    }
        //    else if (newGame == "no" || newGame == "No")
        //    {
        //        Environment.Exit(0);
        //    }
        //}
    }
}
