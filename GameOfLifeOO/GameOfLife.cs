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
            
            ui = new UiController();
            InitRules();
            InitBoard();
            


            //lokale Variable für Autorun (autorun)
            //lokale Variable Höhe (x)
            //lokale Variable Breite (y)
            //InitRules für Höhe, Breite und Autorun
            //Autorun in Rules-Kontruktor
            //Rules, Höhe und Breite in Board-Kontruktor

            //InitRules mit ref? Oder lieber die drei Asks einzeln und =? Oder Alternative?
        }

        private void ShowGame()
        {

        }

        private void GoToNextGen()
        {
            //if: Autorun true/false?
            //Case: Key 


            //AddGenCounter
        }

        private void InitRules()
        {
            ui.ShowTitleScreen(); //Nimmt Defalutwert -1
            bool autorun = ui.AskForAutorun();
            rules = new Rules(autorun);
        }

        private void InitBoard()
        {
            int height = ui.AskForHeight();
            int width = ui.AskForWidth();
            board = new Board(height, width, rules);
        }
    }
}
