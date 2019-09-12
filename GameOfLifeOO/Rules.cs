using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLifeOO
{
    class Rules
    {
        public bool Autorun { get; set; }
        public int AliveMinNeighbours { get; private set; } = 2;
        public int AliveMaxNeighbours { get; private set; } = 3;
        public int DeadMinNeighbours { get; private set; } = 3;
        public int DeadMaxNeighbours { get; private set; } = 3;

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
