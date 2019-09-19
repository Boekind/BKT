using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Calculator
    {
        public const int MAX_LENGTH = 15; 
        public string AddNumber(string result, string number)
        {

            if (result.Length >= MAX_LENGTH)
            {
                return result;
            }

            if (result == "0")
            {
                 result = number;
            }
            else
            {
                result += number;
            }

            return result;
        }

        //public string AddComma(string result)
        //{

        //}
    }
}
