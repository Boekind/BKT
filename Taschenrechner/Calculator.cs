using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class  Calculator
    {
        public const int MAX_LENGTH = 10; 
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

        public string SinCosTan(string newValue, string op)
        {
            double newValueD = double.Parse(newValue);
            double test;

            switch (op)
            {
                case "sin":
                    newValue = (Math.Sin(newValueD)).ToString();
                    return newValue;
                case "cos":
                    newValue = (Math.Cos(newValueD)).ToString();
                    return newValue;
                case "tan":
                    newValue = (Math.Tan(newValueD)).ToString();
                    return newValue;
                case "square":
                    newValue = (Math.Pow(newValueD, 2)).ToString();
                    test = Math.Pow(newValueD, 2);
                    return newValue;
                case "root":
                    newValue = (Math.Sqrt(newValueD)).ToString();
                    return newValue;
                default:
                    break;
            }
            return newValue;
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
                    case "Mod":
                        if (newValue == "0")
                        {
                            return oldValue;
                        }
                        newValue = (oldValueD %= newValueD).ToString();
                        return newValue;
                    case "x^y":
                        newValue = (Math.Pow(oldValueD, newValueD).ToString());
                        return newValue;
                    case "%":
                        newValue = (oldValueD * (newValueD / 100)).ToString();
                        return newValue;

                    default:
                        break;
                    
                }
                return newValue;
            }

            

        }

       

        
    }
}
