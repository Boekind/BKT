using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MiniManagement
{
    class RealEstateManagement
    {
        public static string GetData(Object obj)
        {
            string output = "";
            Type objType = obj.GetType();
            PropertyInfo[] propertyInfos = objType.GetProperties();

            foreach (var item in propertyInfos)
            {
                output += $"{item.Name}: {item.GetValue(obj)}\n";
                //Console.WriteLine($"{item.Name}: {item.GetValue(home)}");
            }

            return output;
        }
    }


}
