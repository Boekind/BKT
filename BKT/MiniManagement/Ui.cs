using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniManagement
{
    class Ui
    {
        public ConsoleKey AskMenu()
        {
            Console.WriteLine("Was machen?");
            //Console.WriteLine("1)\tImmobilien-Liste anzeigen");  Wird immer links angezeigt
            Console.WriteLine("1)\tImmobilie anzeigen");
            Console.WriteLine("2)\tImmobilie hinzufügen");
            Console.WriteLine("3)\tImmobilie löschen");

            return Console.ReadKey(true).Key;
        }
    }
}
