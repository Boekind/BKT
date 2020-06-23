using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace MiniManagement
{
    class RealEstateManagement
    {
        //string fileName = Path.Combine(Environment.CurrentDirectory, "RealEstates.txt");
        string fileName = @"C:\Users\Bökint\Documents\BKT\BKT\MiniManagement\RealEstates.txt";
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

        public void LoadJson()
        {
            List<RealEstate> tempList = JsonConvert.DeserializeObject<List<RealEstate>>(File.ReadAllText(fileName));

            if (tempList != null)
            {
                reList = tempList;
            }
        }

        public void SaveJson()
        {
            //string fileName = @"C:\Users\Bökint\Desktop\TestFile.txt";
            string jsonString = JsonConvert.SerializeObject(reList, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
            File.WriteAllText(fileName, jsonString);
        }

        public void LoadBasic()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);

            List<RealEstate> tempList = (List<RealEstate>)formatter.Deserialize(stream);
            stream.Close();

            if (tempList != null)
            {
                reList = tempList;
            }

        }

        public void SaveBasic()
        {
            //string fileName1 = @"C:\Users\Bökint\Documents\BKT\BKT\MiniManagement\RealEstates.txt";
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, reList);
            stream.Close();
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
