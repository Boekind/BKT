using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLifeOO
{
    class UiController
    {
        private const string ALIVE = "  ";
        private const string DEAD = "  ";
        public int FirstLine { get; set; } = 0;

        public static void Jump(int x, int y)
        {
            Console.CursorLeft = x;

            Console.CursorTop = y;
        }

        public static void WriteCentered(string text, int yIndex)  //nicht static, weil Ui-Klasse?
        {
            int beginX = (Console.BufferWidth / 2) - (text.Length / 2);

            Jump(beginX, yIndex);

            Console.Write(text);
        }

        public void Resize(int w, int h)
        {
            int minLimitW = 44;
            int minLimitH = 9;

            if (w < minLimitW)
                w = minLimitW;

            if (h < minLimitH)
                h = minLimitH;

            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(w, h);
            Console.SetWindowSize(w, h);
        }

        public void ShowTitleScreen(int genCounter = -1) //Defaultwert = -1
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            WriteCentered("Conway's Game of Life", FirstLine + 1); 
            Console.ResetColor();
            if (genCounter > -1)
            {
                WriteCentered($"Generation: {genCounter}", FirstLine + 2);
            }
            else
            {
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        //public void ShowBoard(Cell[,] board)
        //{
        //    for (int counterX = 0; counterX < board.GetLength(0); counterX++)
        //    {
        //        for (int counterY = 0; counterY < board.GetLength(1); counterY++)
        //        {
        //            if (board[counterX,counterY].IsAliveInNextGen)
        //            {
        //                Console.BackgroundColor = ConsoleColor.DarkGreen;
        //            }
        //            Console.Write(board[counterX, counterY].IsAliveInNextGen ? $"{ALIVE} " : $"{DEAD} ");
        //            Console.BackgroundColor = ConsoleColor.Black;
        //        }
        //        Console.WriteLine("");
        //    }
        //}

        public void ShowBoard(Cell[,] board, int genCounter)
        {

            if (genCounter == 0)
            {
                for (int x = 0; x < board.GetLength(0); x++)
                {
                    for (int y = 1; y < board.GetLength(1); y++)
                    {

                        if (board[x, y].IsAliveInNextGen)
                        {
                            Jump((x * 2) + (((Console.WindowWidth - (board.GetLength(0) * 2)) / 2) + 1), y + FirstLine + 6);
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"{ALIVE}");
                            Console.BackgroundColor = ConsoleColor.Black;

                        }
                        else if (!board[x, y].IsAliveInNextGen)
                        {
                            Jump((x * 2) + (((Console.WindowWidth - (board.GetLength(0) * 2)) / 2)+1), y + FirstLine + 6);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine($"{DEAD}");
                            Console.BackgroundColor = ConsoleColor.Black;

                        }
                    }
                }
            }
            else
            {
                for (int x = 0; x < board.GetLength(0); x++)
                {
                    for (int y = 1; y < board.GetLength(1); y++)
                    {
                        if (board[x, y].IsAliveInNextGen != board[x, y].IsAlive)
                        {
                            Jump((x * 2) + (((Console.WindowWidth - (board.GetLength(0) * 2)) / 2) +1), y + FirstLine + 6);

                            if (board[x, y].IsAliveInNextGen)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine($"{ALIVE}");
                                Console.BackgroundColor = ConsoleColor.Black;
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.WriteLine($"{DEAD}");
                                Console.BackgroundColor = ConsoleColor.Black;
                            }
                        }
                    }
                }
            }
            
        }


        public bool AskForAutorun()
        {
            bool autoError = false;
            WriteCentered("Soll das Spiel manuell (m) oder automatisch (a) ablaufen?", FirstLine + 3);
            Jump((Console.BufferWidth / 2), FirstLine + 4);
            do
            {
                var key = Console.ReadKey(true).Key;
                autoError = false;

                if (key == ConsoleKey.M)
                {
                    return false;
                }
                else if (key == ConsoleKey.A)
                {
                    return true;
                }
                else
                {
                    ErrorMessage("Ungültige Eingabe! Bitte versuche es erneut.", FirstLine + 4);
                    Jump((Console.BufferWidth / 2), FirstLine + 4);
                    autoError = true;
                }
            } while (autoError);
            return false;
        }

        public int AskForHeight()
        {
            int boardHeight = 0;
            bool heightError = false;

            do
            {
                heightError = false;
                WriteCentered("Höhe: ", FirstLine + 5);
                try
                {
                    boardHeight = int.Parse(Console.ReadLine());

                    if ((boardHeight + 13 > Console.LargestWindowHeight))
                    {
                        ErrorMessage($"Zahl zu groß. Bitte wähle eine Zahl bis {Console.LargestWindowHeight - 13}.",FirstLine + 5);
                        heightError = true;
                    }
                    else if (boardHeight <= 0)
                    {
                        ErrorMessage("Ungültige Eingabe. Bitte wähle eine Zahl größer 0.",FirstLine + 5);
                        heightError = true;
                    }
                }
                catch (Exception)
                {
                    ErrorMessage("Eingabe ist keine Zahl! Bitte versuche es erneut.", FirstLine + 5);
                    heightError = true;

                }
            } while (heightError);

            return boardHeight;
        }

        public int AskForWidth()
        {
            int boardWidth = 0;
            bool widthError = false;

            do
            {
                widthError = false;
                WriteCentered("Breite: ", FirstLine + 7);
                try
                {
                    boardWidth = int.Parse(Console.ReadLine());

                    if (((boardWidth * 2) + 13 > Console.LargestWindowWidth))
                    {
                        ErrorMessage($"Zahl zu groß. Bitte wähle eine Zahl bis {(Console.LargestWindowWidth - 13) / 2}.", FirstLine +7);
                        widthError = true;
                    }
                    else if (boardWidth <= 0)
                    {
                        ErrorMessage("Ungültige Eingabe. Bitte wähle eine Zahl größer 0.", FirstLine + 7);
                        widthError = true;
                    }
                }
                catch (Exception)
                {
                    ErrorMessage("Eingabe ist keine Zahl! Bitte versuche es erneut.", FirstLine + 7);
                    widthError = true;
                }

            } while (widthError);

            return boardWidth;

        }

        public void ErrorMessage(string text, int y)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteCentered(text, y);
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Threading.Thread.Sleep(750);
            ClearLine(y);
        }

        private void ClearLine(int y)
        {
            Jump(0, y);
            Console.Write("\r" + new string(' ', Console.BufferWidth - 1) + "\r");
        }

        public void ShowBorder(Cell[,] board)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            //╔ ═ ╗ ║ ╚ ╝
            int oben = FirstLine + 6;
            int unten = FirstLine + 6 + board.GetLength(1);
            int links = (((Console.WindowWidth - (board.GetLength(1) * 2)) / 2));
            int rechts = (((Console.WindowWidth - (board.GetLength(1) * 2)) / 2) + board.GetLength(0)*2)+1 ;

            WriteBorder(links, oben, "╔");
            WriteBorder(rechts , oben, "╗");
            WriteBorder(links, unten, "╚");
            WriteBorder(rechts, unten, "╝");

            for (int i = links + 1; i < rechts; i++)
            {
                WriteBorder(i, oben, "═");
                WriteBorder(i, unten, "═");
            }

            for (int i = oben + 1; i < unten; i++)
            {
                WriteBorder(links, i, "║");
                WriteBorder(rechts, i, "║");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private void WriteBorder(int x, int y, string text)
        {
            Jump(x, y);
            Console.WriteLine(text);
        }
    }
}
