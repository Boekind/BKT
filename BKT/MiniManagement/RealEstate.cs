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

        public Address Address { get; set; }


        public RealEstate()
        {

        }
        public RealEstate(bool forSale, double purchasePrice, bool forRent, double rentalPrice, Address address)
        {
            ForSale = forSale;
            PurchasePrice = purchasePrice;
            ForRent = forRent;
            RentalPrice = rentalPrice;
            Address = address;
        }

        public override string ToString()
        {
            return RealEstateManagement.GetData(this);

        }
    }
}
