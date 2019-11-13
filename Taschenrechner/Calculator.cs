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

        public string OneOperand(string newValue, string op)
        {
            double newValueD = double.Parse(newValue);

            switch (op)
            {
                case "sin":
                    newValue = (Math.Sin(newValueD)).ToString();
                    break;
                case "cos":
                    newValue = (Math.Cos(newValueD)).ToString();
                    break;
                case "tan":
                    newValue = (Math.Tan(newValueD)).ToString();
                    break;
                case "square":
                    newValue = (Math.Pow(newValueD, 2)).ToString();
                    break;
                case "root":
                    newValue = (Math.Sqrt(newValueD)).ToString();
                    break;
                case "aSin":
                    newValue = (Math.Asin(newValueD)).ToString();
                    break;
                case "aCos":
                    newValue = (Math.Acos(newValueD)).ToString();
                    break;
                case "aTan":
                    newValue = (Math.Atan(newValueD)).ToString();
                    break;
                case "ceil":
                    newValue = (Math.Ceiling(newValueD)).ToString();
                    break;
                case "round":
                    newValue = (Math.Round(newValueD, MidpointRounding.AwayFromZero)).ToString();
                    break;
                case "floor":
                    newValue = (Math.Floor(newValueD)).ToString();
                    break;
                case "ln":
                    newValue = (Math.Log(newValueD)).ToString();
                    break;
                default:
                    break;
            }
            if (double.IsNaN(double.Parse(newValue)) || double.IsInfinity(double.Parse(newValue)))
            {
                throw new Exception();
            }
            return newValue;
        }

        public string TwoOperands(string newValue, string op, string oldValue) //Grundrechenarten
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
