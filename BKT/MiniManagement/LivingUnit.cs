using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniManagement
{
    abstract class LivingUnit : RealEstate
    {
        public int Rooms { get; set; }

        public LivingUnit()
        {

        }
        public LivingUnit(int rooms, bool forSale, double purchasePrice, bool forRent, double rentalPrice, Address address) : base(forSale, purchasePrice, forRent, rentalPrice, address)
        {
            Rooms = rooms;
        }
    }
}
