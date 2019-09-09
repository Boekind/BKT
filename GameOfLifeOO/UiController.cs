using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLifeOO
{
    class UiController
    {
        public static void JumpY(int x, int y)
        {
            Console.CursorLeft = x;

            Console.CursorTop = y;
        }

        public static void WriteCentered(string text, int yIndex)
        {
            int beginX = (Console.BufferWidth / 2) - (text.Length / 2);

            JumpY(beginX, yIndex);

            Console.Write(text);
        }

        public void ShowTitleScreen()
        {

        }

        public void ShowBoard(Cell[,] board)
        {

        }

        public bool AskForAutorun()
        {
            return true;
        }

        public int AskForWidth()
        {
            return 5;
        }

        public int AskForHeight()
        {
            return 5;
        }
    }
}
