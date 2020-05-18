using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniManagement
{
    abstract class RealEstate
    {
        public bool ForSale { get; set; }
        public double PurchasePrice { get; set; }
        public bool ForRent { get; set; }
        public double RentalPrice { get; set; }

        public override string ToString()
        {
            return RealEstateManagement.GetData(this);

        }
    }
}
