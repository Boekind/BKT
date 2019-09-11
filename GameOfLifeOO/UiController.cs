using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLifeOO
{
    class UiController
    {
        private const string ALIVE = "o";
        private const string DEAD = "x";

        public static void JumpY(int x, int y)
        {
            Console.CursorLeft = x;

            Console.CursorTop = y;
        }

        public static void WriteCentered(string text, int yIndex)  //nicht static, weil Ui-Klasse?
        {
            int beginX = (Console.BufferWidth / 2) - (text.Length / 2);

            JumpY(beginX, yIndex);

            Console.Write(text);
        }

        public static void Resize(int w, int h)
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Conway's Game of Life");
            Console.ResetColor();
            if (genCounter > -1)
            {
                Console.WriteLine($"Generation: {genCounter}", 1);
            }
            else
            {
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        public void ShowBoard(Cell[,] board)
        {
            for (int counterX = 0; counterX < board.GetLength(1); counterX++)
            {
                for (int counterY = 0; counterY < board.GetLength(0); counterY++)
                {
                    Console.WriteLine(board[counterX, counterY].IsAlive ? ALIVE : DEAD);    //So möglich?                
                }
            }
        }

        public bool AskForAutorun()
        {
            bool autoError = false;
            Console.WriteLine("Soll das Spiel manuell (m) oder automatisch (a) ablaufen?");

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
                    ErrorMessage("Ungültige Eingabe! Bitte versuche es erneut.");
                    autoError = true;
                }
            } while (autoError);
            return true;
        }

        public int AskForWidth()
        {
            int boardWidth = 0;
            bool widthError = false;

            do
            {
                widthError = false;
                Console.Write("Breite: ");
                try
                {
                    boardWidth = int.Parse(Console.ReadLine());

                    if (((boardWidth * 2) + 8 > Console.LargestWindowWidth))
                    {
                        ErrorMessage($"Zahl zu groß. Bitte wähle eine Zahl bis {(Console.LargestWindowWidth - 8) / 2}.");
                        widthError = true;
                    }
                    else if (boardWidth <= 0)
                    {
                        ErrorMessage("Ungültige Eingabe. Bitte wähle eine Zahl größer 0.");
                        widthError = true;
                    }
                }
                catch (Exception)
                {
                    ErrorMessage("Eingabe ist keine Zahl! Bitte versuche es erneut.");
                    widthError = true;
                }

            } while (widthError);

            return boardWidth;

        }

        public int AskForHeight()
        {
            int boardHeight = 0;
            bool heightError = false;

            do
            {
                heightError = false;
                Console.Write("Höhe: ");
                try
                {
                    boardHeight = int.Parse(Console.ReadLine());

                    if ((boardHeight + 8 > Console.LargestWindowHeight))
                    {
                        ErrorMessage($"Zahl zu groß. Bitte wähle eine Zahl bis {Console.LargestWindowHeight - 8}.");
                        heightError = true;
                    }
                    else if (boardHeight <= 0)
                    {
                        ErrorMessage("Ungültige Eingabe. Bitte wähle eine Zahl größer 0.");
                        heightError = true;
                    }
                }
                catch (Exception)
                {
                    ErrorMessage("Eingabe ist keine Zahl! Bitte versuche es erneut.");
                    heightError = true;

                }
            } while (heightError);

            return boardHeight;
        }

        public void ErrorMessage(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
