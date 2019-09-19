using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLifeOO
{
    class GameOfLife
    {
        private Board board;
        private Rules rules;
        private UiController ui;

        public void StartNewGame()
        {
            InitGoL();
            Console.Clear();
            //ui.ShowBorder(board.boardArray);
            while (true)
            {
                ShowGame();
            }
        }

        private void ShowGame()
        {
            GoToNextGen();
        }

        private void GoToNextGen()
        {
            bool keyToNextGen = false;
            if (board.GenCounter > 0)
            {
                board.SetStateInNextGen(rules);
            }
            ui.ShowTitleScreen(board.GenCounter);
            ui.ShowBoard(board.boardArray, board.GenCounter);
            

            while (!keyToNextGen)
            {
                if (!rules.Autorun)
                {
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.Spacebar:
                        case ConsoleKey.Enter:
                            board.ChangeGen();
                            keyToNextGen = true;
                            break;
                        case ConsoleKey.R:
                            StartNewGame();
                            break;
                        default:
                            //Nichts passiert.
                            break;
                    }
                }
                else
                {
                    board.ChangeGen();
                    keyToNextGen = true;
                    System.Threading.Thread.Sleep(60); //Alle x ms wird das Array neu generiert
                    if (Console.KeyAvailable)
                    {
                        if (Console.ReadKey(true).Key == ConsoleKey.R)
                        {
                            StartNewGame();
                        }
                    }
                }
            }

        
        }

        private void InitRules()
        {
            ui.ShowTitleScreen(); //Nimmt Defaultwert -1
            System.Threading.Thread.Sleep(500);
            bool autorun = ui.AskForAutorun();
            rules = new Rules(autorun);
        }

        private void InitBoard()
        {
            int height = ui.AskForHeight();
            int width = ui.AskForWidth();
            board = new Board(height, width, rules);
        }

        private void InitGoL()
        {
            Console.CursorVisible = false;
            Console.Clear();
            ui = new UiController();
            ui.Resize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            InitRules();
            InitBoard();
            board.AddGenCounter();
        }
    }
}
