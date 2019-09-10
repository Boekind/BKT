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
            bool autorun = false;
            int height = 0;
            int width = 0;
            ui = new UiController();
            InitRules(ref autorun, ref height, ref width);
            rules = new Rules(autorun);
            board = new Board(height, width, rules);


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

        private void InitRules(ref bool autorun, ref int height, ref int width)
        {
            ui.ShowTitleScreen(-1);
            autorun = ui.AskForAutorun();
            height = ui.AskForHeight();
            width = ui.AskForWidth();
            
        }
    }
}
