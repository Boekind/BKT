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
        const string EMPTY = " ";

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
        static int initialCellCounter;

        //Variable um mit ReadKey(true) in die nächste Generation zu kommen:

        //Anzahl der Nachbarn:
        static int neighboursCounter;

        //Zufallszahl:
        static Random rng = new Random();

        //Generation:
        static int genCounter;

        static void Main(string[] args)
        {
            StartOfGame();
            while (true)
            {
                ShowGame();
            }

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
            CreateFields(X);
            ReadInitialCells();
            FillInitialCells();

        }

        //Methode, um Spielverlauf darzustellen
        static public void ShowGame()

        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Conway's Game of Life");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Generation: " + genCounter);
            Console.WriteLine("");
            genCounter++;
            ShowField(ref fieldCurrent);
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
                initialCellCounter = int.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Eingabe ist keine Zahl! Bitte versuche es erneut.");
                Console.ForegroundColor = ConsoleColor.White;
                ReadInitialCells();
            }


        }

        static public void FillInitialCells()
        {

            for (int p = 0; p < initialCellCounter; p++)
            {
                int rngX = rng.Next(0, X);
                int rngY = rng.Next(0, X);
                if (!CheckIfCellIsAlive(fieldCurrent[rngX, rngY]))
                {
                    fieldCurrent[rngX, rngY] = ALIVE;
                }
                else
                {
                    p--;
                }

            }
        }

        //Methode, um Spielfeld anzeigen zu lassen
        static public void ShowField(ref string[,] field)
        {
            while (counterX < X)
            {

                while (counterY < X)
                {
                    Console.Write(field[counterX, counterY] + " ");
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
            bool keyToNextGen = false;

            //If(Console.KeyAvailable) -> Nur, wenn eine Taste gedrückt wird!
            while (!keyToNextGen)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Spacebar:
                    case ConsoleKey.Enter:
                        ChangeGen();
                        keyToNextGen = true;
                        break;
                    default:
                        //Nichts passiert.
                        break;

                }
            }
        }


        static public void ChangeGen()
        {
            fieldPrevious = new string[fieldCurrent.GetLength(0), fieldCurrent.GetLength(1)];

            for(int x = 0; x < fieldCurrent.GetLength(0); x++)
            {
                for(int y = 0; y < fieldCurrent.GetLength(1); y++)
                {
                    fieldPrevious[x, y] = fieldCurrent[x, y];
                }
            }

            CellStateInNextGen();
        }

        //Methode zur Überprüfung, was mit der jeweiligen Zelle in der nächsten Phase passiert
        static public void CellStateInNextGen()
        {

            while (counterX < X)
            {
                while (counterY < X)
                {
                    neighboursCounter = CheckNeighbourCount(counterX, counterY);
                    if (CheckIfCellIsAlive(fieldPrevious[counterX, counterY]) == true)
                    {
                        if (neighboursCounter != 2 || neighboursCounter != 3)
                        {
                            fieldCurrent[counterX, counterY] = EMPTY;
                        }

                    }
                    else
                    {
                        if (neighboursCounter == 3)
                        {
                            fieldCurrent[counterX, counterY] = ALIVE;
                        }
                    }

                    neighboursCounter = 0;
                    counterY++;
                }
                counterY = 0;
                counterX++;
            }
            counterX = 0;
            counterY = 0;

        }

        //Methode, um einzelnen Nachbarn zu Überprüfen
        static public void CheckNeighbour(int checkX, int checkY)
        {
            //neighboursCounter = 0;
            try
            {
                if (fieldPrevious[checkX, checkY] == ALIVE)
                {
                    neighboursCounter++;
                }
            }
            catch (Exception)
            {

            }

        }

        //Methode zur Überprüfung der Anzahl der lebenden Nachbarn
        static public int CheckNeighbourCount(int coordX, int coordY)  //counterX,counterY
        {
            CheckNeighbour(coordX - 1, coordY - 1);
            CheckNeighbour(coordX, coordY - 1);
            CheckNeighbour(coordX + 1, coordY - 1);
            CheckNeighbour(coordX - 1, coordY);
            CheckNeighbour(coordX + 1, coordY);
            CheckNeighbour(coordX - 1, coordY + 1);
            CheckNeighbour(coordX, coordY + 1);
            CheckNeighbour(coordX + 1, coordY + 1);
            return neighboursCounter;

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
