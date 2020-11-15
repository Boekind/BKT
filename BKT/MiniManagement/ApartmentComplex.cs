using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniManagement
{
    [Serializable]
    public class ApartmentComplex : RealEstate
    {
        List<Apartment> apartmentList = new List<Apartment>();

        public ApartmentComplex(bool forSale, double purchasePrice, bool forRent, double rentalPrice, Address address) : base(forSale, purchasePrice, forRent, rentalPrice, address)
        {

        }
    }
}
