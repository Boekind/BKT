using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Calculator
    {
        public const int MAX_LENGTH = 13; 
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

        public string AddComma(string result)
        {
            if (!result.Contains(","))
            {
                result += ",";
                return result;
            }
            else
            {
                return result;
            }
        }

        public string Calculate(string newValue, string op, string oldValue) //Grundrechenarten
        {
            double newValueD = double.Parse(newValue);
            double oldValueD;

            if (string.IsNullOrEmpty(oldValue))
            {
                return newValue;   
            }
            else
            {
                 oldValueD = double.Parse(oldValue);
                switch (op)
                {

                    case "+":
                        newValue = (oldValueD += newValueD).ToString();
                        return newValue;
                    case "-":
                        newValue = (oldValueD -= newValueD).ToString();
                        return newValue;
                    case "*":
                        newValue = (oldValueD *= newValueD).ToString();
                        return newValue;
                    case "/":
                        newValue = (oldValueD /= newValueD).ToString();
                        return newValue;
                    default:
                        break;
                }
                return newValue;
            }

            

        }

       

        
    }
}
