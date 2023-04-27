using Figgle;

namespace ETKlassenBibliothek
{
    public class ETMenue
    {
        public static void ET_Menue()
        {
            bool Exit = false;

            do
            {

                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("ET-Submenü"));

                //Konsolentitel wird geändert.
                Console.Title = "ET-Submenü";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> ET-Submenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");

                //Beschreibung der Software.
                Console.WriteLine("\n\nMit der Software 'BFTMulti-Tool' sollen wiederkehrende oder besonders aufwendige\n" +
                                  "Aufgabenaus dem schulischen Kontext erleichtert oder gelöst werden. Diese Aufgaben\n" +
                                  "ergeben sich aus den Problemstellungen aus dem Unterricht der Berufsfachschule für Technik.\n\n");

                string HauptAusw;


                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Solarenergie-REchner");
                Console.WriteLine("\t2 - Bauteil-Rechner");
                Console.WriteLine("\t3 - Elektro-Sicherheit");
                Console.WriteLine("\t4 - Rechner für Elektrische-Werte");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine().ToLower();

                switch (HauptAusw)
                {
                    case "1":
                        Console.Clear();
                        //Hier das Etechnikmenü aufrufen+
                        Feature1.Feature_1();
                        break;

                    case "2":
                        Console.Clear();
                        //Hier das Informationstechnikmenü aufrufen
                        break;

                    case "3":
                        Console.Clear();
                        //Hier das Mathematikmenü aufrufen
                        break;

                    case "4":
                        Console.Clear();
                        //Hier Feature4 aufrufen
                        //Feature4.Feature_4();
                        break;

                    case "exit":
                        Exit = true;
                        break;
                    default:

                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();

                        (int, int) cPosAM = Console.GetCursorPosition();

                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                        break;
                }

            } while (!Exit);


        }
    }
}