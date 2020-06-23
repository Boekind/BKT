﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniManagement
{
    class Tester
    {
        static void Main(string[] args)
        {
            Ui ui = new Ui();
            Address address = new Address("Deutschland", "NRW", "57399", "Kirchhundem", "Kapellenweg", "3");
            Home home = new Home(1.2, 3, true, 4.5, false, 0, address);
            Apartment apartment = new Apartment(true, 4, false, 0, true, 9.4, address);
            ApartmentComplex ac = new ApartmentComplex(true, 123.44, false, 0, address);

            string line = "-------------------";


            ////Console.WriteLine(address.ToString());
            ////Console.WriteLine(line);
            ////Console.WriteLine(home.ToString());
            ////Console.WriteLine(line);
            ////Console.WriteLine(apartment.ToString());
            ////Console.WriteLine(line);
            ////Console.WriteLine(ac.ToString());



            RealEstateManagement rem = new RealEstateManagement();

            //rem.Load();

            //rem.Add(home);
            //rem.Add(apartment);


            rem.LoadBasic();


            ////In Methode:
            for (int i = 0; i < rem.GetCount(); i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(rem.Get(i).GetType().Name);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(rem.Get(i));
                Console.WriteLine(line);
            }
            //rem.Save();
            //Console.ReadKey();
            ////Console.Clear();
            ////rem.Delete(home);
            ////rem.Delete(apartment);

            ////for (int i = 0; i < rem.GetCount(); i++)
            ////{
            ////    Console.ForegroundColor = ConsoleColor.Red;
            ////    Console.WriteLine(rem.Get(i).GetType().Name);
            ////    Console.ForegroundColor = ConsoleColor.Gray;
            ////    Console.WriteLine(rem.Get(i));
            ////    Console.WriteLine(line);
            ////}
            ////rem.Save();
            ////Console.ReadKey();
            ////rem.Delete(1);

            ////Console.Clear();


            ////for (int i = 0; i < rem.GetCount(); i++)
            ////{
            ////    Console.ForegroundColor = ConsoleColor.Red;
            ////    Console.WriteLine(rem.Get(i).GetType().Name);
            ////    Console.ForegroundColor = ConsoleColor.Gray;
            ////    Console.WriteLine(rem.Get(i));
            ////    Console.WriteLine(line);
            ////}

            ////rem.Save();

            //while (true)
            //{
            //    Console.WriteLine(Console.ReadKey(true).Key);
            //}

            //switch (ui.AskMenu())
            //{
            //    case ConsoleKey.D1:
            //    case ConsoleKey.NumPad1:
            //        Console.WriteLine("Immobilie X wird angezeigt");
            //        break;
            //    case ConsoleKey.D2:
            //    case ConsoleKey.NumPad2:
            //        Console.WriteLine("Immobilie hinzufügen");
            //        break;
            //    case ConsoleKey.D3:
            //    case ConsoleKey.NumPad3:
            //        Console.WriteLine("Immobilie löschen");
            //        break;
            //}



            Console.ReadKey();
        }
    }
}
