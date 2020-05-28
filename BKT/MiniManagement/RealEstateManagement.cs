using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MiniManagement
{
    class RealEstateManagement
    {
        string fileName = Path.Combine(Environment.CurrentDirectory, "RealEstates.txt");
        Home Test;

        List<RealEstate> reList;
        public RealEstateManagement()
        {
            reList = new List<RealEstate>();

            Address address = new Address("Test", "Test", "Test", "Test", "Test", "Test");
            Test = new Home(3.5, 6, true, 89, false, 0, address);
        }

        public void Add (RealEstate re)
        {
            reList.Add(re);
        }

        public void Delete(RealEstate re)
        {
            reList.Remove(re);
        }

        public void Delete(int index)
        {
            reList.RemoveAt(index);
        }

        public RealEstate Get(int index)
        {
            return reList[index];
        }

        public int GetCount()
        {
            return reList.Count();
        }

        public void Load()
        {

            List<RealEstate> tempList = JsonConvert.DeserializeObject<List<RealEstate>>(File.ReadAllText(fileName));

            if (tempList != null)
            {
                reList = tempList;
            }
        }

        public void Save()
        {
            //string fileName = @"C:\Users\Bökint\Desktop\TestFile.txt";
            string jsonString = JsonConvert.SerializeObject(reList, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
            File.WriteAllText(fileName, jsonString);
        }




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
