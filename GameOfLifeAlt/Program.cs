using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLifeNeu
{
    class Program
    {
        //Mit Array als Übergabeparameter arbeiten
        static int counterX = 0;
        static int counterY = 0;

        //Zelle ist lebendig: Status "o"
        const string ALIVE = "o ";
        //Anzahl der lebenden Zellen
        static int aliveCounter;
        //Zelle ist leer: Status "x"
        const string EMPTY = "x ";
        //Anzahl der toten Zellen
        // static int deadCounter;



        //Konsolengröße festlegen:

        //Variable für die Höhe:
        //static int consoleLength;

        //Variable für die Breite:
        //static int consoleWidth;

        //Array mit aktuellem Stand
        static string[,] fieldCurrent;
        //Variable heightArray:
        static int heightArray;
        //Variable widthArray:
        static int widthArray;

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


        //Zum testen:
        static int heightConsole;
        static int widthConsole;

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



        //Titeltextfarbwechsel am Anfang


        //Titeltext
        static public void Title()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteCentered("Conway's Game of Life", 0);
            Console.ResetColor();
            if (genCounter > -1)
            {
                WriteCentered($"Generation: {genCounter}", 1);
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

            WriteCentered("Soll das Spiel manuell (m) oder automatisch (a) ablaufen?", 8);
            WriteCentered("", 9);


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
                    WriteCentered("Ungültige Eingabe! Bitte versuche es erneut.", 9);
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(1000);
                    WriteCentered("", 9);
                }
            } while (autoError);
        }
        //2. Methode ohne widthArray oder geht auch anders?


        //Methode zum Start des Spiels
        static public void StartOfGame()
        {
            Resize(60, 22);
            Console.CursorVisible = false;
            for (int i = 10; i <= 100; i += 10)
            {
                WriteCentered($"Spiel wird geladen...{i}%", 0);
                System.Threading.Thread.Sleep(80);
            }
            Console.Clear();


            Title();
            System.Threading.Thread.Sleep(500);
            ReadFieldSize();
            CreateFields(heightArray, widthArray);
            ReadInitialCells();
            FillInitialCells();


            Auto();

            Resize((widthArray * 2) + 8, heightArray + 8);



        }

        //Methode, um Spielverlauf darzustellen
        static public void ShowGame()

        {
            aliveCounter = 0;
            Console.CursorVisible = false;
            Console.Clear();
            genCounter++;
            Title();
            Console.WriteLine("");
            ShowField(ref fieldCurrent);

            WriteCentered($"Lebende Zellen: {aliveCounter} | Tote Zellen: {heightArray * widthArray - aliveCounter}", heightArray + 5);
            //Maximal [W 80|H 53]:
            //WriteCentered($"Höhe: {heightConsole} {heightArray + 8} {Console.LargestWindowHeight} | Breite: {widthConsole} {(widthArray * 2) + 8} {Console.LargestWindowWidth}", heightArray + 5);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            WriteCentered("Zum Neustarten 'R' drücken.", heightArray + 7);
            Console.ForegroundColor = ConsoleColor.White;
            GoToNextGen();
        }

        //Methode um Spielfeldgröße einzulesen
        static public void ReadFieldSize()
        {
            WriteCentered("Wie groß soll das Spielfeld sein?", 3);

            GetHeightConsole();
            GetWidthConsole();

        }

        //Resize((widthArray * 2) + 8, heightArray + 8);
        static public void GetHeightConsole()
        {
            bool getHeightError = false;

            do
            {
                getHeightError = false;
                WriteCentered("Höhe: ", 4);
                try
                {
                    heightArray = int.Parse(Console.ReadLine());

                    if ((heightArray + 8 > Console.LargestWindowHeight))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        WriteCentered($"Zahl zu groß. Bitte wähle eine Zahl bis {Console.LargestWindowHeight - 8}.", 4);
                        Console.ForegroundColor = ConsoleColor.White;
                        getHeightError = true;
                        System.Threading.Thread.Sleep(2000);
                        WriteCentered("                                                 ", 4);
                    }
                    else if (heightArray <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        WriteCentered("Eingabe ungültig. Bitte wähle eine Zahl größer 0.", 4);
                        Console.ForegroundColor = ConsoleColor.White;
                        getHeightError = true;
                        System.Threading.Thread.Sleep(2000);
                        WriteCentered("                                                 ", 4);
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    WriteCentered("Eingabe ist keine Zahl! Bitte versuche es erneut.", 4);
                    Console.ForegroundColor = ConsoleColor.White;
                    getHeightError = true;
                    System.Threading.Thread.Sleep(2000);
                    WriteCentered("                                                 ", 4);

                }
            } while (getHeightError);


        }


        //Resize((widthArray * 2) + 8, heightArray + 8);
        static public void GetWidthConsole()
        {

            bool getWidthError = false;

            do
            {
                getWidthError = false;
                WriteCentered("Breite: ", 5);
                try
                {
                    widthArray = int.Parse(Console.ReadLine());

                    if (((widthArray * 2) + 8 > Console.LargestWindowWidth))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        WriteCentered($"Zahl zu groß. Bitte wähle eine Zahl bis {(Console.LargestWindowWidth - 8) / 2}.", 5);
                        Console.ForegroundColor = ConsoleColor.White;
                        getWidthError = true;
                        System.Threading.Thread.Sleep(2000);
                        WriteCentered("                                                 ", 5);
                    }
                    else if (widthArray <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        WriteCentered("Eingabe ungültig. Bitte wähle eine Zahl größer 0.", 5);
                        Console.ForegroundColor = ConsoleColor.White;
                        getWidthError = true;
                        System.Threading.Thread.Sleep(2000);
                        WriteCentered("                                                 ", 5);
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    WriteCentered("Eingabe ist keine Zahl! Bitte versuche es erneut.", 5);
                    Console.ForegroundColor = ConsoleColor.White;
                    getWidthError = true;
                    System.Threading.Thread.Sleep(2000);
                    WriteCentered("                                                 ", 5);
                }

            } while (getWidthError);

        }

        //Anzahl der am Anfang lebenden Zellen abrufen (Muster? Random? Überprüfen, ob Zelle schon lebendig ist (Methode CheckIfCellIsAlive?))
        static public void ReadInitialCells()
        {
            bool RICError = false;
            WriteCentered("Wie viele Zellen sollen in der Ausgangssituation leben?", 6);
            //WriteCentered("", 7);


            do
            {
                RICError = false;
                WriteCentered("", 7);
                try
                {
                    initialCellCounter = int.Parse(Console.ReadLine());
                    if (initialCellCounter > (heightArray * widthArray))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        WriteCentered("Zahl ist zu hoch! Bitte versuche es erneut.", 7);
                        Console.ForegroundColor = ConsoleColor.White;
                        RICError = true;
                        System.Threading.Thread.Sleep(2000);
                        WriteCentered("                                                 ", 7);
                    }
                    else
                    {
                    }

                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    WriteCentered("Eingabe ist keine Zahl! Bitte versuche es erneut.", 7);
                    Console.ForegroundColor = ConsoleColor.White;
                    //ReadInitialCells();
                    RICError = true;
                    System.Threading.Thread.Sleep(2000);
                    WriteCentered("                                                 ", 7);
                }
            } while (RICError);


        }

        static public void FillInitialCells()
        {

            for (int p = 0; p < initialCellCounter; p++)
            {
                int rngX = rng.Next(0, heightArray);
                int rngY = rng.Next(0, widthArray);
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
            while (counterX < heightArray)
            {

                for (int counterCentered = ((((widthConsole)) - ((widthArray * 2)) + 1) / 2); counterCentered > 0; counterCentered--)
                {
                    Console.Write(" ");
                }
                while (counterY < widthArray)
                {


                    if (field[counterX, counterY] == ALIVE /*&& fieldPrevious[counterX,counterY] == ALIVE*/)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        aliveCounter++;

                    }
                    /* else if( field[counterX,counterY]==EMPTY && fieldPrevious[counterX,counterY] == ALIVE)
                     {
                         Console.ForegroundColor = ConsoleColor.Blue;
                     }  */
                    else if (field[counterX, counterY] == EMPTY)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write(field[counterX, counterY]);
                    counterY++;
                    Console.ResetColor();
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


            //-> Nur, wenn eine Taste gedrückt wird!
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
                        /*case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;*/                           //??????
                        default:
                            //Nichts passiert.
                            break;

                    }

                }
                else
                {
                    ChangeGen();
                    keyToNextGen = true;
                    System.Threading.Thread.Sleep(200); //Alle 0,2 Sekunden wird das Array neu generiert
                    if (Console.KeyAvailable)
                    {
                        if (Console.ReadKey(true).Key == ConsoleKey.R)
                        {
                            Reset();
                        }
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

            while (counterX < heightArray)
            {
                while (counterY < widthArray)
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
            while (counterX < heightArray)
            {
                while (counterY < widthArray)
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
            aliveCounter = 0;
            Console.Clear();
            heightArray = 0;
            widthArray = 0;
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




        public static void WriteCentered(string text, int yIndex)
        {
            int beginX = (Console.BufferWidth / 2) - (text.Length / 2);

            JumpY(beginX, yIndex);

            Console.Write(text);
        }

        public static void JumpX(int x)
        {
            Console.CursorLeft = x;
        }


        //Methode, um die Konsolengröße festzulegen:
        public static void Resize(int w, int h)
        {
            int minLimitW = 44;
            int minLimitH = 9;


            if (w < minLimitW)
                w = minLimitW;

            if (h < minLimitH)
                h = minLimitH;


            heightConsole = h;
            widthConsole = w;

            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(w, h);
            Console.SetWindowSize(w, h);


        }

    }
}



//If Abfrage in ShowGame für manuell und automatisch: z.B. true = automatisch; Wird am Anfang abgefragt
//Ausprobieren am Laptop Höhe = 53 und höher!
//Ausprobieren am Laptop Breite = ??? und höher!




//LINQ <3
//Bei Anzahl Nachbarn switch case anstatt If -> Schneller?


//Änderungen 10.07. Arbeit:
//-Läuft automatisch durch 
//  -If Key.Available bei automatisch, damit Reset
//  -Autorun-Abfrage um die Keys für in die nächste Generation

//-Lebende/tote Zellen schreiben lassen
//  -Reset weiter nach unten verlagert und bei Resize aus heightArray+8 heightArray+9 gemacht


//Änderungen 16.07. Arbeit: 
//-Versucht, Mindest- und Maximalgröße herauszufinden
//  -Abhängig von Bildschirm/Auflösung?

//Änderungen 17.07. Arbeit:
//-Formel für Mittiges Array
//  -Hälfte von Console - Hälfte von Array-1 mit " " => linken Rand auffüllen!
//
//

//Änderungen 25.07. Arbeit:
//-Formael für Array / mit * ersetzt
//Bei Konsole / 2 entfernt
// das / 2 für Ergebnis, nachdem Konsolenbreite - (Arraybreite *2)

//Änderungen 26.07. Arbeit:
//- Zähler in for-Schleife in ShowField zu (((widthConsole)) - ((widthArray * 2))+1)/2 korrigiert
//Maximalgröße mit Console.LargestWindowHeight/-Width herausgefunden
//-> Überprüft, ob eingegebene Zahlen diese nach Rechnung überschreiten