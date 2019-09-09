using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLifeOO
{
    class Board
    {
        public int GenCounter { get; private set; } = -1;
        Cell[,] boardArray;
        public Board(int height, int width, Rules rules)
        {
            boardArray = new Cell[height, width];

        }

        public void FillInitialCells(int ChanceThatCellsAlive) //z.B. 40 für 40%ige Wahrscheinlichkeit, dass die Zelle lebt -> Dichte von 40%
        {
            Random rng = new Random();
            
            for (int counterX = 0; counterX < boardArray.GetLength(1); counterX++)
            {
                for (int counterY = 0; counterY < boardArray.GetLength(0); counterY++)
                {
                    boardArray[counterX, counterY] = new Cell(rng.Next(100) <= ChanceThatCellsAlive);
                }
            }
        }

        public void ChangeGen(Rules rules)
        {
            for (int counterX = 0; counterX < boardArray.GetLength(1); counterX++)
            {
                for (int counterY = 0; counterY < boardArray.GetLength(0); counterY++)
                {
                    rules.CheckAndSetStateInNextGen(boardArray[counterX, counterY], GetLivingNeighbourCount(counterX, counterY));
                }
            }
        }

        public int GetLivingNeighbourCount(int x, int y)
        {
            return 5;
        }

        public void AddGenCounter()
        {
            GenCounter++;
        }
    }
}
