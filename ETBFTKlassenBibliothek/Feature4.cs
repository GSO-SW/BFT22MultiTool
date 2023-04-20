using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETBFTKlassenBibliothek
{
    internal class Feature4
    {
        internal static void Feature_4()
        {
            Console.WriteLine("Test Feature 4");
            
            string Rechner;
            string sVolt;
            double dVolt;
            string sWatt;
            double dWatt;
            string sWiderstand;
            double dWiderstand;
            double Leistung;
            double dAmpere;
            string sAmpere;
            string sSpannung;
            double dSpannung;
            string sStrom;
            double dStrom;
            bool schleife = true;
            bool antiddoostool;
            double Exit;



            do
            {
                Console.WriteLine("Taschenrechner für Elektrische Werte");

                Console.WriteLine("Welchen Wert Wollen sie errechnen");
                Console.WriteLine("1. Volt");
                Console.WriteLine("2. Watt");
                Console.WriteLine("3. Widerstand");
                Console.WriteLine("4. Spannung");
                Console.WriteLine("5. Strom");
                Console.WriteLine("6. SUPPORT / HILFE");
                Console.WriteLine("7. Beenden");
                Rechner = Convert.ToString(Console.ReadLine());
                Console.Clear();

                switch (Rechner)
                {
                    case "1":
                        Console.WriteLine("Volt Rechner");
                        Console.WriteLine("Volt Formel = Watt / Ampere");
                        do
                        {
                            Console.WriteLine("Bitte geben sie ihren Watt Verbrauch an");
                            sWatt = Console.ReadLine();
                            antiddoostool = double.TryParse(sWatt, out dWatt);
                            if (antiddoostool != true)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Falsche eingabe");
                                Console.ResetColor();
                            }
                        } while (antiddoostool == false);
                        do
                        {
                            Console.WriteLine("Bitte geben sie ihren Wert für Ampere an");
                            sAmpere = Console.ReadLine();
                            antiddoostool = double.TryParse(sAmpere, out dAmpere);
                            if (antiddoostool != true)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Falsche eingabe");
                                Console.ResetColor();
                            }
                        } while (antiddoostool == false);
                        dVolt = Convert.ToDouble($"{dWatt / dAmpere}");
                        Console.Clear();
                        Console.WriteLine($"Ihr Volt beträgt: {dVolt}");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        Console.WriteLine("Watt Rechner");
                        Console.WriteLine("Watt Formel: Volt * Ampere");
                        do
                        {
                            Console.WriteLine("Bitte geben sie ihren Volt Verbrauch an");
                            sVolt = Console.ReadLine();
                            antiddoostool = double.TryParse(sVolt, out dVolt);
                            if (antiddoostool != true)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Falsche eingabe");
                                Console.ResetColor();
                            }
                        } while (antiddoostool == false);
                        do
                        {
                            Console.WriteLine("Bitte geben sie ihren Wert für Ampere an");
                            sAmpere = Console.ReadLine();
                            antiddoostool = double.TryParse(sAmpere, out dAmpere);
                            if (antiddoostool != true)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Falsche eingabe");
                                Console.ResetColor();
                            }
                        } while (antiddoostool == false);
                        dWatt = Convert.ToDouble($"{dVolt * dAmpere}");
                        Console.Clear();
                        Console.WriteLine($"Ihr Watt beträgt: {dWatt}");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.WriteLine("Widerstand Rechner");
                        Console.WriteLine("Widerstand Formel: Spannung / Strom");
                        do
                        {
                            Console.WriteLine("Bitte geben sie ihren Spannungs Wert an");
                            sSpannung = Console.ReadLine();
                            antiddoostool = double.TryParse(sSpannung, out dSpannung);
                            if (antiddoostool != true)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Falsche eingabe");
                                Console.ResetColor();
                            }
                        } while (antiddoostool == false);
                        do
                        {
                            Console.WriteLine("Bitte geben sie ihren Wert für Strom an");
                            sStrom = Console.ReadLine();
                            antiddoostool = double.TryParse(sStrom, out dStrom);
                            if (antiddoostool != true)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Falsche eingabe");
                                Console.ResetColor();
                            }
                        } while (antiddoostool == false);
                        dWiderstand = Convert.ToDouble($"{dSpannung / dStrom}");
                        Console.WriteLine($"Ihr Widerstand beträgt: {dWiderstand}");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.WriteLine("Spannugns Rechner");
                        Console.WriteLine("Spannungs Formel: Widerstand * Strom");
                        do
                        {
                            Console.WriteLine("Bitte geben sie ihren Wert für Widerstand an");
                            sWiderstand = Console.ReadLine();
                            antiddoostool = double.TryParse(sWiderstand, out dWiderstand);
                            if (antiddoostool != true)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Falsche eingabe");
                                Console.ResetColor();
                            }
                        } while (antiddoostool == false);
                        do
                        {
                            Console.WriteLine("Bitte geben sie ihren Wert für Strom an");
                            sStrom = Console.ReadLine();
                            antiddoostool = double.TryParse(sStrom, out dStrom);
                            if (antiddoostool != true)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Falsche eingabe");
                                Console.ResetColor();
                            }
                        } while (antiddoostool == false);
                        dSpannung = Convert.ToDouble($"{dWiderstand * dStrom}");
                        Console.WriteLine($"Ihr Spannungs Wert beträgt: {dSpannung}");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        Console.WriteLine("Strom Rechner");
                        Console.WriteLine("Strome Formel: Spannung / Widerstand");
                        do
                        {
                            Console.WriteLine("Bitte geben sie ihren Wert für Spannung an");
                            sSpannung = Console.ReadLine();
                            antiddoostool = double.TryParse(sSpannung, out dSpannung);
                            if (antiddoostool != true)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Falsche eingabe");
                                Console.ResetColor();
                            }
                        } while (antiddoostool == false);
                        do
                        {
                            Console.WriteLine("Bitte geben sie ihren Wert für Widerstand an");
                            sWiderstand = Console.ReadLine();
                            antiddoostool = double.TryParse(sWiderstand, out dWiderstand);
                            if (antiddoostool != true)
                            {
                                Console.WriteLine("Falsche eingabe");
                            }
                        } while (antiddoostool == false);
                        dStrom = Convert.ToDouble($"{dSpannung / dWiderstand}");
                        Console.WriteLine($"Ihr Strom-Wert beträgt: {dStrom}");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "6":
                        Console.WriteLine("Wenn Sie Hilfe brauchen Rufen sie diese Nummer an: !-> 1516 8405862 <-!");
                        Console.ReadKey();
                        Console.Clear();
                        schleife = true;
                        break;
                    case "7":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Falsche eingabe");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (schleife == true);

        }
    }
}
