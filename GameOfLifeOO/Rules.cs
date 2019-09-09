using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLifeOO
{
    class Rules
    {
        public bool Autorun { get; set; }
        public int AliveMinNeighbours { get; private set; }
        public int AliveMaxNeighbours { get; private set; }
        public int DeadMinNeighbours { get; private set; }
        public int DeadMaxNeighbours { get; private set; }


        public void CheckAndSetStateInNextGen(Cell cell, int numberOfNeighbours)
        {

        }
    }
}
