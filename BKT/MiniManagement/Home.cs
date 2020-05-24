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


        public Home()
        {

        }
        public Home(double plotSize, int rooms, bool forSale, double purchasePrice, bool forRent, double rentalPrice, Address address) : base(rooms, forSale, purchasePrice, forRent, rentalPrice, address)
        {
            PlotSize = plotSize;
        }



    }
}
