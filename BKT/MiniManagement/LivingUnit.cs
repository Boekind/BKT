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
    }
}
