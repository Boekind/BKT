using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLifeNeu
{
    class Program
    {

        //Mit Array als Übergabeparameter arbeiten!
        static int counterX = 0;
        static int counterY = 0;

        //Zelle ist lebendig: Status "o"
        const string ALIVE = "o";
        //Zelle ist leer: Status "x"
        const string EMPTY = "x";

        //Konsolengröße festlegen:

        //Variable für die Länge:
        static int consoleLength;
        //Variable für die Breite:
        static int consoleWidth;

        //Array mit aktuellem Stand
        static string[,] fieldCurrent;
        //Variable X:
        static int X;
        //Variable Y:
        //static int Y;  

        //Array mit vorherigem Stand
        static string[,] fieldPrevious;

        //Anzahl der Zellen, die anfangs lebendig sind
        static int cellCounter;

        //Variable um mit ReadKey(true) in die nächste Generation zu kommen:



        static void Main(string[] args)
        {
            StartOfGame();

            ShowGame();
        }

        

        /* Später!
        //Methode, um die Konsolengröße festzulegen:

        static public void SetConsoleSize()
        {
            //consoleLength/Width = Spielfeldlänge + 1/2/3/...?
            Console.SetBufferSize(consoleLength,consoleWidth);
            Console.SetWindowSize(consoleLength,consoleWidth);
        } */


        //Methode zum Start des Spiels
        static public void StartOfGame()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Conway's Game of Life");
            Console.ForegroundColor = ConsoleColor.White;
            ReadFieldSize();
            ReadInitialCells();

            Console.Read();

        }

        //Methode, um Spielverlauf darzustellen
        static public void ShowGame()

        {
            ShowField();
            GoToNextGen();
        }

        //Methode um Spielfeldgröße einzulesen
        static public void ReadFieldSize()
        {
            Console.WriteLine("Wie groß soll das Spielfeld sein?");
            try
            {
                X = int.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Eingabe ist keine Zahl! Bitte versuche es erneut.");
                Console.ForegroundColor = ConsoleColor.White;
                ReadFieldSize();
            }
        }
        //Anzahl der am Anfang lebenden Zellen abrufen (Muster? Random? Überprüfen, ob Zelle schon lebendig ist (Methode CheckIfCellIsAlive?))
        static public void ReadInitialCells()
        {
            Console.WriteLine("Wie viele Zellen sollen in der Ausgangssituation leben?");
            try
            {
                cellCounter = int.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Eingabe ist keine Zahl! Bitte versuche es erneut.");
                Console.ForegroundColor = ConsoleColor.White;
                ReadFieldSize();
            }


        }

        //Methode, um Spielfeld anzeigen zu lassen
        static public void ShowField()
        {
            while (counterX < X)
            {

                while (counterY < X)
                {
                    Console.Write(fieldCurrent[counterX, counterY]);
                    counterY++;
                }
                counterY = 0;
                counterX++;
                Console.WriteLine();
            }
            counterX = 0;
            counterY = 0;
        }


        //Methode um in nächste Generation zu gehen (Per Tastendruck (ReadKey?))
        static public void GoToNextGen()
        {





            //If(Console.KeyAvailable) -> Nur, wenn eine Taste gedrückt wird!

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Spacebar:
                    ChangeGen();
                    break;
                default:
                    //Nichts passiert.
                    break;

            }
        }


        static public void ChangeGen()
        {
            fieldPrevious = fieldCurrent;

            //durchlaufen lassen
            //aktuelle Zelle = CellSateInNextGen()
        }

        //Methode zur Überprüfung, was mit der jeweiligen Zelle in der nächsten Phase passiert
        static public void CellStateInNextGen(ref string[,] field)
        {

            while (counterX < X)
            {
                while (counterY < X)
                {
                    if (CheckIfCellIsAlive(field[counterX, counterY]) == true)
                    {
                        //Anzahl der Nachbarn
                    }

                    counterY++;
                }
                counterY = 0;
                counterX++;
            }
            counterX = 0;
            counterY = 0;

        }
        //Methode zur Überprüfung der Nachbarn
        static public void CheckNeighbourCount()
        {

        }
        //Dazu Methode für den aktuellen Zustand der Zellen:
        //--> Methode: Ist die Zelle lebendig?
        static public bool CheckIfCellIsAlive(string i)
        {
            if (i == ALIVE)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Methode, um Array zu füllen:
        static public void FillArray(ref string[,] field)
        {
            while (counterX < X)
            {
                while (counterY < X)
                {
                    field[counterX, counterY] = EMPTY;
                    counterY++;
                }
                counterY = 0;
                counterX++;
            }
            counterX = 0;
            counterY = 0;
        }

        //Methode, um das aktuelle Feld zu erstellen
        static public void CreateFields(int x)
        {
            fieldCurrent = new string[x, x];
            FillArray(ref fieldCurrent);
            fieldPrevious = new string[x, x];
            FillArray(ref fieldPrevious);
        }


  

        //string[,] name = new string[,]

    }
}
