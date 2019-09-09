using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLifeOO
{
    class Cell
    {
        public bool IsAlive { get; private set; }
        public bool IsAliveInNextGen { get; private set; }

        public Cell (bool initialState)
        {
            IsAlive = initialState;
        }

        public void ChangeState()
        {
            this.IsAliveInNextGen = !this.IsAliveInNextGen;

        }

        public void NextGen()
        {
            this.IsAlive = this.IsAliveInNextGen;
        }


    }
}
