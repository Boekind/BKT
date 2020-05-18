using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniManagement
{
    class Home : LivingUnit
    {
        public double PlotSize { get; set; }

        public Home(double plotSize)
        {
            PlotSize = plotSize;
        }



    }
}
