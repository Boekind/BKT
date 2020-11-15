using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniManagement
{
    [Serializable]
     public class Apartment : LivingUnit
    {
        public bool CommonEntrance { get; set; }

        public Apartment(bool commonEntrance, int rooms, bool forSale, double purchasePrice, bool forRent, double rentalPrice, Address address) : base(rooms, forSale, purchasePrice, forRent, rentalPrice, address)
        {
            CommonEntrance = commonEntrance;
        }
    }
}
