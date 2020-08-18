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
        string fileNameBasic = @"C:\Users\Bökint\Documents\BKT\BKT\MiniManagement\ImmoWelt\RealEstatesBasic.txt";
        string fileNameJson = @"C:\Users\Bökint\Documents\BKT\BKT\MiniManagement\ImmoWelt\RealEstatesJson.txt";

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

        public void AddNew()
        {
            RealEstate newRealEstate;
            int welcheArt = 0;

            Console.WriteLine("Welche Art?");
            //1 für Home, 2 für Apartment, 3 für Apartmentkomplex
            //Apartment zum Komplex hinzufügen?
            Console.WriteLine("Zum Verkauf?");

            Console.WriteLine("Verkaufspreis?");
            Console.WriteLine("Zur Vermietung?");
            Console.WriteLine("Mietpreis?");
            Console.WriteLine("Adresse:");
            Console.WriteLine("Land?");
            Console.WriteLine("Bundesstaat/Bundesland?");
            Console.WriteLine("PLZ?");
            Console.WriteLine("Stadt?");
            Console.WriteLine("Straße?");
            Console.WriteLine("Hausnummer?");

            switch (welcheArt)
            {
                case 1: // Home
                    Console.WriteLine("Anzahl Räume?");
                    Console.WriteLine("Größe Grundstück (m²)");
                    //newRealEstate = new Home();
                    break;
                case 2: //Apartment
                    Console.WriteLine("Anzahl Räume?");
                    Console.WriteLine("Gemeinsamer Eingang?");
                    //newRealEstate = new Apartment();
                    break;
                case 3: //Apartmentkomplex
                    //newRealEstate = new ApartmentComplex();
                    break;
            }
        }

        public string GetInputValue(string input)
        {

            return "";
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

        public void ShowAllRealEstates()
        {
            string line = "-------------------";


            for (int i = 0; i < GetCount(); i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Get(i).GetType().Name);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(Get(i));
                Console.WriteLine(line);
            }
        }

        public void LoadJson()
        {
            List<RealEstate> tempList = JsonConvert.DeserializeObject<List<RealEstate>>(File.ReadAllText(fileNameJson));

            if (tempList != null)
            {
                reList = tempList;
            }
        }

        public void SaveJson()
        {
            string jsonString = JsonConvert.SerializeObject(reList, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });
            File.WriteAllText(fileNameJson, jsonString);
        }

        public void LoadBasic()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileNameBasic, FileMode.Open, FileAccess.Read, FileShare.Read);

            List<RealEstate> tempList = (List<RealEstate>)formatter.Deserialize(stream);
            stream.Close();

            if (tempList != null)
            {
                reList = tempList;
            }

        }

        public void SaveBasic()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileNameBasic, FileMode.Create, FileAccess.Write, FileShare.None);
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
