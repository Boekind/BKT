using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLifeOO
{
    class Board
    {
        public int GenCounter { get; private set; } = -1;
        public Cell[,] boardArray;
        public Board(int height, int width, Rules rules)
        {
            boardArray = new Cell[width, height];
            FillInitialCells(rules.ChanceThatCellIsAlive);
        }

        public void FillInitialCells(int ChanceThatCellsAlive) //z.B. für X% Wahrscheinlichkeit, dass die Zelle lebt -> Dichte von X
        {
            Random rng = new Random();
            
            for (int counterX = 0; counterX < boardArray.GetLength(0); counterX++)
            {
                for (int counterY = 0; counterY < boardArray.GetLength(1); counterY++)
                {
                    //int x = boardArray.GetLength(0);
                    boardArray[counterX, counterY] = new Cell(rng.Next(100) <= ChanceThatCellsAlive);
                    boardArray[counterX, counterY].FillInitialIsAliveInNextGen();
                    
                }
            }
        }


        //Keine doppelten Schleifendurchläufe durch Methode mit Schleifendurchlauf, die Cell zurückgibt?

        public void SetStateInNextGen(Rules rules) //ursprünglich in ChangeGen
        {
            for (int counterX = 0; counterX < boardArray.GetLength(0); counterX++)
            {
                for (int counterY = 0; counterY < boardArray.GetLength(1); counterY++)
                {
                    if(rules.CheckIfStateChangesInNextGen(boardArray[counterX, counterY], GetLivingNeighbourCount(counterX, counterY)))
                    {
                        boardArray[counterX, counterY].ChangeState();
                    }
                }
            }

            //DoForEveryCell((int counterX, int counterY) => {
            //    rules.CheckAndSetStateInNextGen(boardArray[counterX, counterY], GetLivingNeighbourCount(counterX, counterY));
            //});

            //DoForEveryCell((int counterX, int counterY) => {
            //    boardArray[counterX, counterY].NextGen();
            //});
        }

        //private void DoForEveryCell(Action<int, int> todo)
        //{
        //    for (int counterX = 0; counterX < boardArray.GetLength(1); counterX++)
        //    {
        //        for (int counterY = 0; counterY < boardArray.GetLength(0); counterY++)
        //        {
        //            todo(counterX, counterY);
        //        }
        //    }
        //}

        public void ChangeGen()
        {
            for (int counterX = 0; counterX < boardArray.GetLength(0); counterX++)
            {
                for (int counterY = 0; counterY < boardArray.GetLength(1); counterY++)
                {
                    boardArray[counterX, counterY].NextGen();
                }
            }
            AddGenCounter();
        }


        private bool IsNeighbourAlive(int x, int y)
        {
            if (x >= 0 && x < boardArray.GetLength(0) && y >= 0 && y < boardArray.GetLength(1))
            {
                return boardArray[x, y].IsAlive; //Keine zusätzliche if-Abfrage, ob Zelle IsAlive benötigt, da IsAlive schon ein bool ist.
            }
            else
            {
                return false;
            }
            
        }

        private int GetLivingNeighbourCount(int x, int y)
        {
            int neighbours = 0;

            if(IsNeighbourAlive(x - 1, y - 1)) neighbours++;
            if(IsNeighbourAlive(x, y - 1)) neighbours++;
            if(IsNeighbourAlive(x + 1, y - 1)) neighbours++;
            if(IsNeighbourAlive(x - 1, y)) neighbours++;
            if(IsNeighbourAlive(x + 1, y)) neighbours++;
            if(IsNeighbourAlive(x - 1, y + 1)) neighbours++;
            if(IsNeighbourAlive(x, y + 1)) neighbours++;
            if(IsNeighbourAlive(x + 1, y + 1)) neighbours++;

            return neighbours;
        }

        public void AddGenCounter()
        {
            GenCounter++;
        }
    }
}
