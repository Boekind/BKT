using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace MiniManagement
{
    public class RealEstateManagement
    {
        string fileNameBasic = Path.Combine(Environment.CurrentDirectory, "RealEstatesBasic.txt");
        string fileNameJson = Path.Combine(Environment.CurrentDirectory, "RealEstatesJson.txt");


        Home Test;
        public List<RealEstate> reList { get; set; } 
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

            Console.WriteLine("Welche Art von Immobilie?");
            Console.WriteLine("1 für Haus; 2 für Apartment; 3 für Apartmentkomplex");
            int formOfRealEstate = int.Parse(Console.ReadLine());
            //1 für Home, 2 für Apartment, 3 für Apartmentkomplex
            //Apartment zum Komplex hinzufügen?
            Console.WriteLine("Zum Verkauf? (true/false)");
            bool forSale = bool.Parse(Console.ReadLine());

            Console.WriteLine("Verkaufspreis?");
            double purchasePrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Zur Vermietung? (true/false)");
            bool forRent = bool.Parse(Console.ReadLine());
            Console.WriteLine("Mietpreis?");
            double rentalPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Adresse:");

            Console.WriteLine("Land?");
            string country = Console.ReadLine();
            Console.WriteLine("Bundesstaat/Bundesland?");
            string state = Console.ReadLine();
            Console.WriteLine("PLZ?");
            string zip = Console.ReadLine();
            Console.WriteLine("Stadt?");
            string city = Console.ReadLine();
            Console.WriteLine("Straße?");
            string street = Console.ReadLine();
            Console.WriteLine("Hausnummer?");
            string houseNumber = Console.ReadLine();

            Address address = new Address(country, state, zip, city, street, houseNumber);

            int rooms = 0;

            switch (formOfRealEstate)
            {
                case 1: // Home
                    Console.WriteLine("Anzahl Räume?");
                    rooms = int.Parse(Console.ReadLine());
                    Console.WriteLine("Größe Grundstück (m²)");
                    double plotSize = double.Parse(Console.ReadLine());

                    newRealEstate = new Home(plotSize, rooms, forSale, purchasePrice, forRent, rentalPrice, address);
                    break;
                case 2: //Apartment
                    Console.WriteLine("Anzahl Räume?");
                    rooms = int.Parse(Console.ReadLine());
                    Console.WriteLine("Gemeinsamer Eingang? (true/false)");
                    bool commonEntrance = bool.Parse(Console.ReadLine());

                    newRealEstate = new Apartment(commonEntrance, rooms, forSale, purchasePrice, forRent, rentalPrice, address);
                    //newRealEstate = new Apartment();
                    break;
                case 3: //Apartmentkomplex
                    newRealEstate = new ApartmentComplex(forSale, purchasePrice, forRent, rentalPrice, address);
                    //newRealEstate = new ApartmentComplex();
                    break;
                default: //Fehler noch abfangen
                    newRealEstate = new Home();
                    break;
            }

            reList.Add(newRealEstate);
            Console.WriteLine("Immobilie wurde hinzugefügt!");
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
            List<RealEstate> tempList = JsonConvert.DeserializeObject<List<RealEstate>>(File.ReadAllText(fileNameJson), new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });

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
