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
        //static int consoleLength;

        //Variable für die Breite:
        //static int consoleWidth;

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
            Game();
        }

        static public void Game()
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

        //Titeltext
        static public void Title

        //Methode zum Start des Spiels
        static public void StartOfGame()
        {
            genCounter = -1;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Conway's Game of Life");
            Console.ForegroundColor = ConsoleColor.White;
            ReadFieldSize();
            CreateFields(X);
            ReadInitialCells();
            FillInitialCells();
            //Resize(X + 5, X + 4);

        }

        //Methode, um Spielverlauf darzustellen
        static public void ShowGame()

        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            WriteCentered("Conway's Game of Life", 0) ;
            Console.ForegroundColor = ConsoleColor.White;
            WriteCentered($"Generation: {genCounter}",1);
            Console.WriteLine("");
            genCounter++;
            ShowField(ref fieldCurrent);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Zum Neustarten 'R' drücken.");
            Console.ForegroundColor = ConsoleColor.White;
            GoToNextGen();
        }

        //Methode um Spielfeldgröße einzulesen
        static public void ReadFieldSize()
        {
            Console.WriteLine("Wie groß soll das Spielfeld sein?");
            GetX();

        }

        static public int GetX()
        {
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


            return X;
        }

        //Anzahl der am Anfang lebenden Zellen abrufen (Muster? Random? Überprüfen, ob Zelle schon lebendig ist (Methode CheckIfCellIsAlive?))
        static public void ReadInitialCells()
        {
            bool RICError = false;
            Console.WriteLine("Wie viele Zellen sollen in der Ausgangssituation leben?");
            do
            {
                RICError = false;
                try
                {
                    initialCellCounter = int.Parse(Console.ReadLine());
                    if (initialCellCounter > (X * X))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Zahl ist zu hoch! Bitte versuche es erneut.");
                        Console.ForegroundColor = ConsoleColor.White;
                        RICError = true;
                    }
                    else
                    {

                    }

                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Eingabe ist keine Zahl! Bitte versuche es erneut.");
                    Console.ForegroundColor = ConsoleColor.White;
                    ReadInitialCells();
                }
            } while (RICError);


        }

        static public void FillInitialCells()
        {

            for (int p = 0; p < initialCellCounter; p++)
            {
                int rngX = rng.Next(0, X);
                int rngY = rng.Next(0, X);
                if (fieldCurrent[rngX, rngY] == EMPTY)
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
                    if (field[counterX, counterY] == ALIVE /*&& fieldPrevious[counterX,counterY] == ALIVE*/)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    /* else if( field[counterX,counterY]==EMPTY && fieldPrevious[counterX,counterY] == ALIVE)
                     {
                         Console.ForegroundColor = ConsoleColor.Blue;
                     }  */
                    else if (field[counterX, counterY] == EMPTY)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write(field[counterX, counterY] + " ");
                    counterY++;
                    Console.ForegroundColor = ConsoleColor.White;
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
                    case ConsoleKey.R:
                        Reset();
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
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

            for (int x = 0; x < fieldCurrent.GetLength(0); x++)
            {
                for (int y = 0; y < fieldCurrent.GetLength(1); y++)
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
                    if (fieldPrevious[counterX, counterY] == ALIVE)
                    {
                        if (neighboursCounter == 2 || neighboursCounter == 3)
                        {
                            //fieldCurrent[counterX, counterY] = ALIVE;
                        }
                        else
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

        /* 
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
        */


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

        //Methode, um Variablen zu resetten:
        static public void Reset()
        {
            Console.Clear();
            // X = 0;
            // initialCellCounter = 0;
            // Array.Clear(fieldCurrent,0,fieldCurrent.Length);
            // Array.Clear(fieldPrevious,0,fieldPrevious.Length);

            Game();
        }

        public static void Jump(int x, int y)
        {
            Console.CursorLeft = x;
            Console.CursorTop = y;
        }


        public static void Resize(int h, int w)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(w, h);
            Console.SetWindowSize(w, h);
        }

        public static void WriteCentered(string text, int yIndex)
        {
            int beginX = (Console.BufferWidth / 2) - (text.Length / 2);

            Jump(beginX, yIndex);

            Console.Write(text);
        }
    }
}


//If Abfrage in ShowGame für manuell und automatisch: z.B. true = automatisch; Wird am Anfang abgefragt
//Titeltext-Methode
//Letzte Genereationen vergleichen, weil unendlich/letzter Zustand mit hash Zeug -> Frag Marius
//LINQ <3

