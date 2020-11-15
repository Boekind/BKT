using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Net.Configuration;

namespace MiniManagement
{
    public class Tester
    {
        static void Main(string[] args)
        {
            Ui ui = new Ui();
            Address address = new Address("Deutschland", "NRW", "57399", "Kirchhundem", "Kapellenweg", "3");
            Home home = new Home(1.2, 3, true, 4.5, false, 0, address);
            Apartment apartment = new Apartment(true, 4, false, 0, true, 9.4, address);
            ApartmentComplex ac = new ApartmentComplex(true, 123.44, false, 0, address);

            RealEstateManagement rem = new RealEstateManagement();

            rem.LoadJson();

            //Es fehlt noch:
            //Fehlerüberprüfug der Eingaben bei AddNew()
            //Immobilien werden nur als RealEstate aus Json geladen (funktionierte mal, jetzt nicht mehr (???))
            //Konsolen-Ui verbessern



            while (true)
            {
                
                Console.Clear();
                switch (ui.AskMenu())
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        rem.ShowAllRealEstates();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        rem.AddNew();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.WriteLine("Index eingeben:");
                        int index = int.Parse(Console.ReadLine());
                        rem.Delete(index);
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.WriteLine("Wird gespeichert.");
                        rem.SaveJson();
                        break;
                }

                Console.ReadKey();
            }

            //string connectionString = "SERVER=localhost; DATABASE= real_estate_management; UID=root; PASSWORD=;";

            //MySqlConnection connection = new MySqlConnection(connectionString);
            //MySqlCommand command = connection.CreateCommand();
            //command.CommandText = "SELECT * FROM apartment_apartmentcomplex";
            //MySqlDataReader Reader;
            //connection.Open();
            //Reader = command.ExecuteReader();

            //while (Reader.Read())
            //{
            //    string row = "";
            //    for (int i = 0; i < Reader.FieldCount; i++)
            //    {
            //        row += Reader.GetValue(i).ToString() + ", ";
            //    }
            //    Console.WriteLine(row);
            //}

            //connection.Close();

            //rem.ShowAllRealEstates();


            //rem.AddNew();

            //rem.ShowAllRealEstates();


        }
    }
}
