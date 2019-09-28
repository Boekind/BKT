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

        public string Calculate(string result, string op, string operand) //Grundrechenarten
        {
            int resultInt = int.Parse(result);
            int operandInt = int.Parse(operand);



            switch (op)
            {
                
                case "+":
                    result = (resultInt += operandInt).ToString();
                    return result;
                case "-":
                    result = (resultInt -= operandInt).ToString();
                    return result;
                case "*":
                    result = (resultInt *= operandInt).ToString();
                    return result;
                case "/":
                    result = (resultInt /= operandInt).ToString();
                    return result;
                default:
                    break;
            }
            return result;

        }

       

        
    }
}
