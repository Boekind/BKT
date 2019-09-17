using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLifeOO
{
    class Rules
    {
        public bool Autorun { get; set; }
        private int AliveMinNeighbours { get; set; } = 2;
        private int AliveMaxNeighbours { get; set; } = 3;
        private int DeadMinNeighbours { get; set; } = 3;
        private int DeadMaxNeighbours { get; set; } = 3;
        public int ChanceThatCellIsAlive { get; set; } = 50;

        public Rules(bool autorun)
        {
            Autorun = autorun;
        }

        public bool CheckIfStateChangesInNextGen(Cell cell, int numberOfNeighbours)
        {
            if (cell.IsAlive && (numberOfNeighbours < AliveMinNeighbours || numberOfNeighbours > AliveMaxNeighbours))
            {
                return true;
            }
            else if (!cell.IsAlive && numberOfNeighbours >= DeadMinNeighbours && numberOfNeighbours <= DeadMaxNeighbours)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
