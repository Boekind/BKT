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
        static int Y;

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
        static int genCounter = -1;

        //Automatisch oder manuell:
        static bool autorun = false;


        static void Main(string[] args)
        {
            Game();
        }

        static public void Game()
        {

            StartOfGame();
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                ShowGame();
            }
        }




        //Titeltext
        static public void Title()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            WriteCenteredY("Conway's Game of Life", 0);
            Console.ForegroundColor = ConsoleColor.White;
            if (genCounter > -1)
            {
                WriteCenteredY($"Generation: {genCounter}", 1);
            }
            else
            {
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        //Methode, um automatisch oder manuell
        static public void Auto()
        {
            bool autoError = false;

            WriteCenteredY("Soll das Spiel manuell (m) oder automatisch (a) ablaufen?", 8);
            WriteCenteredY("", 9);

            do
            {
                var key = Console.ReadKey().Key;
                autoError = false;

                if (key == ConsoleKey.M)
                {
                    autorun = false;
                }
                else if (key == ConsoleKey.A)
                {
                    autorun = true;
                }
                else
                {
                    autoError = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    WriteCenteredY("Ungültige Eingabe! Bitte versuche es erneut.", 9);
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(2000);
                    WriteCenteredY("", 9);
                }
            } while (autoError);
        }
        //2. Methode ohne Y oder geht auch anders?


        //Methode zum Start des Spiels
        static public void StartOfGame()
        {
            Console.CursorVisible = true;
            for(int i = 10;i<=100; i+=10)
            {
                WriteCenteredY($"Spiel wird geladen...{i}%", 0);
                System.Threading.Thread.Sleep(100);
            }
            Console.Clear();
            Title();
            System.Threading.Thread.Sleep(1000);
            ReadFieldSize();
            CreateFields(X,Y);
            ReadInitialCells();
            FillInitialCells();


            Auto();
            //Resize(X + 50, X + 50);
        }
        
        //Methode, um Spielverlauf darzustellen
        static public void ShowGame()

        {
            Console.CursorVisible = false;
            Console.Clear();
            genCounter++;
            Title();

            ShowField(ref fieldCurrent);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            WriteCenteredY("Zum Neustarten 'R' drücken.", X + 5);
            Console.ForegroundColor = ConsoleColor.White;
            GoToNextGen();
        }

        //Methode um Spielfeldgröße einzulesen
        static public void ReadFieldSize()
        {
            WriteCenteredY("Wie groß soll das Spielfeld sein?", 3);

            GetX();
            GetY();

        }


        static public void GetX()
        {
            bool getXError = false;

            do
            {
                getXError = false;
                WriteCenteredY("X: ", 4);
                try
                {
                    X = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    WriteCenteredY("Eingabe ist keine Zahl! Bitte versuche es erneut.", 4);
                    Console.ForegroundColor = ConsoleColor.White;
                    getXError = true;
                    System.Threading.Thread.Sleep(2000);
                    WriteCenteredY("                                                    ", 4);

                }
            } while (getXError);

            
        }

        static public void GetY()
        {

            bool getYError = false;

            do
            {
                getYError = false;
                WriteCenteredY("Y: ", 5);
                try
                {
                    Y = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    WriteCenteredY("Eingabe ist keine Zahl! Bitte versuche es erneut.", 5);
                    Console.ForegroundColor = ConsoleColor.White;
                    getYError = true;
                    System.Threading.Thread.Sleep(2000);
                    WriteCenteredY("                                                    ", 5);
                }

            } while (getYError);
           
        }

        //Anzahl der am Anfang lebenden Zellen abrufen (Muster? Random? Überprüfen, ob Zelle schon lebendig ist (Methode CheckIfCellIsAlive?))
        static public void ReadInitialCells()
        {
            bool RICError = false;
            WriteCenteredY("Wie viele Zellen sollen in der Ausgangssituation leben?", 6);
            //WriteCenteredY("", 7);


            do
            {
                RICError = false;
                WriteCenteredY("", 7);
                try
                {
                    initialCellCounter = int.Parse(Console.ReadLine());
                    if (initialCellCounter > (X * Y))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        WriteCenteredY("Zahl ist zu hoch! Bitte versuche es erneut.", 7);
                        Console.ForegroundColor = ConsoleColor.White;
                        RICError = true;
                        System.Threading.Thread.Sleep(2000);
                        WriteCenteredY("                                                                                                 ", 7);
                    }
                    else
                    {
                    }

                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    WriteCenteredY("Eingabe ist keine Zahl! Bitte versuche es erneut.", 7);
                    Console.ForegroundColor = ConsoleColor.White;
                    //ReadInitialCells();
                    RICError = true;
                    System.Threading.Thread.Sleep(2000);
                    WriteCenteredY("                                                                                                 ", 7);
                }
            } while (RICError);


        }

        static public void FillInitialCells()
        {

            for (int p = 0; p < initialCellCounter; p++)
            {
                int rngX = rng.Next(0, X);
                int rngY = rng.Next(0, Y);
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

                while (counterY < Y)
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
                if (!autorun)
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
                while (counterY < Y)
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
        static public void CreateFields(int x, int y)
        {
            fieldCurrent = new string[x, y];
            FillArray(ref fieldCurrent);
            fieldPrevious = new string[x, y];
            FillArray(ref fieldPrevious);
        }

        //Methode, um Variablen zu resetten:
        static public void Reset()
        {
            Console.Clear();
            X = 0;
            Y = 0;
            initialCellCounter = 0;
            genCounter = -1;
            // Array.Clear(fieldCurrent,0,fieldCurrent.Length);
            // Array.Clear(fieldPrevious,0,fieldPrevious.Length);

            Game();
        }

        public static void JumpY(int x, int y)
        {
            Console.CursorLeft = x;
            Console.CursorTop = y;
        }




        public static void WriteCenteredY(string text, int yIndex)
        {
            int beginX = (Console.BufferWidth / 2) - (text.Length / 2);

            JumpY(beginX, yIndex);

            Console.Write(text);
        }

        public static void JumpX(int x)
        {
            Console.CursorLeft = x;
        }

        public static void WriteCenteredX(string text)
        {
            int beginX = (Console.BufferWidth / 2) - (text.Length / 2);

            JumpX(beginX);
        }

        //Methode, um die Konsolengröße festzulegen:
        public static void Resize(int w, int h)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(w, h);
            Console.SetWindowSize(w, h);
        }

    }
}


//If Abfrage in ShowGame für manuell und automatisch: z.B. true = automatisch; Wird am Anfang abgefragt
//Titeltext-Methode
//Letzte Genereationen vergleichen, weil unendlich/letzter Zustand mit hash Zeug -> Frag Marius!
//LINQ <3
//Resize -> Frag Marius!
//Fehlermeldungen!
//Fehlermeldung, wenn Zahl zu hoch => Ist keine Zahl?! -> Frag Marius! 


