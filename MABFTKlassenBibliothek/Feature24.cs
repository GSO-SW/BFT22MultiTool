using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MABFTKlassenBibliothek
{
    internal class Feature24
    {

        Console.WriteLine("---------------------------------------");
Console.WriteLine("          Linieare Funktionen          ");
Console.WriteLine("---------------------------------------");
Console.WriteLine("");
Console.WriteLine("Bitte Wählen Sie eines von diesen 7 Themen aus");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("");
Console.WriteLine("1. Gerade Funktion");
Console.WriteLine("");
Console.WriteLine("2. Konstante Funktion");
Console.WriteLine("");
Console.WriteLine("3. Propotionale Funktion");
Console.WriteLine("");
Console.WriteLine("4. Skalierungsfunktion");
Console.WriteLine("");
Console.WriteLine("5. Verschiebungsfunktion");
Console.WriteLine("");
Console.WriteLine("6. Einheitsfunktion");
Console.WriteLine("");
Console.WriteLine("7. Identitätsfunktion");
Console.WriteLine("");
Console.WriteLine("Nun geben Sie die gewünschte Zahl ein");



int Gerade_str = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

if (Gerade_str == 1)
{

    Console.WriteLine("1. Gerade Funktion");
    Console.WriteLine("------------------");
    Console.WriteLine("");


    Console.Write("Geben Sie einen Wert für x ein: ");
    double x = double.Parse(Console.ReadLine());

        Console.Write("Geben Sie einen Wert für m ein: ");
    double m = double.Parse(Console.ReadLine());

        Console.Write("Geben Sie einen Wert für b ein: ");
    double b = double.Parse(Console.ReadLine());

        double y = m * x + b;

        Console.WriteLine("y = " + y);

}
else if (Gerade_str == 2)
{

    Console.WriteLine("2. Konstante Funktion");
    Console.WriteLine("---------------------");
    Console.WriteLine("");


    Console.Write("Gib den y-Wert der konstanten Funktion ein: ");
        double y = double.Parse(Console.ReadLine());

    Console.Write("Gib einen x-Wert ein, um zu überprüfen, ob die Funktion konstant ist: ");
        double x = double.Parse(Console.ReadLine());

        if (y == (y* x))

            Console.WriteLine("Die Funktion ist konstant.");

        else

            Console.WriteLine("Die Funktion ist nicht konstant.");

 }
else if (Gerade_str == 3)
{
    Console.WriteLine("3. Proportionale Funktion");
    Console.WriteLine("-------------------------");
    Console.WriteLine("");


    Console.Write("Gib den Wert von a ein: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Gib den Wert von b ein: ");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.Write("Gib den Wert von x ein: ");
    double x = Convert.ToDouble(Console.ReadLine());

    double y = a * x + b;

    Console.WriteLine("y = {0}", y);

    Console.ReadLine();

}
else if (Gerade_str == 4)
{
    Console.WriteLine("4. Skalierungsfunktion");
    Console.WriteLine("----------------------");
    Console.WriteLine("");


    {
        Console.WriteLine("Geben Sie die Zahl ein, die Sie skalieren möchten:");
        int zahl = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Geben Sie den Skalierungsfaktor ein:");
        float faktor = Convert.ToSingle(Console.ReadLine());

        int skaliert = Skalieren(zahl, faktor);
        Console.WriteLine($"Die skalierte Zahl ist {skaliert}");
    }

    static int Skalieren(int zahl, float faktor)
    {
        return (int)(zahl * faktor);
    }
}
else if (Gerade_str == 5)
{
    Console.WriteLine("5. Verschiebungsfunktion");
    Console.WriteLine("------------------------");
    Console.WriteLine("");




    {
        static void Main()
        {
            Console.WriteLine("Geben Sie die zu verschiebende Zahl ein:");
            int zahl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben Sie die Anzahl der Verschiebungsschritte ein:");
            int verschiebung = Convert.ToInt32(Console.ReadLine());

            int ergebnis = Verschiebungsfunktion(zahl, verschiebung);

            Console.WriteLine("Ergebnis der Verschiebung: " + ergebnis);
        }

        static int Verschiebungsfunktion(int zahl, int verschiebung)
        {
            return zahl << verschiebung;
        }
    }
}
else if (Gerade_str == 6)
{

    Console.WriteLine("6. Einheitsfunktion");
    Console.WriteLine("-------------------");
    Console.WriteLine("");


    {
        Console.WriteLine("Bitte geben Sie eine Zahl ein:");
        double x = Convert.ToDouble(Console.ReadLine());

        if (x == 0)
        {
            Console.WriteLine("f(x) = 1");
        }
        else
        {
            Console.WriteLine("f(x) = 0");
        }

        Console.ReadLine();
    }
}
else if (Gerade_str == 7)
{
    Console.WriteLine("7. Identitätsfunktion");
    Console.WriteLine("---------------------");
    Console.WriteLine("");

    {
        Console.WriteLine("Geben Sie eine beliebige Anzahl von Zahlen ein (durch Leerzeichen getrennt):");
        string input = Console.ReadLine();
        string[] zahlen = input.Split(' ');

        Console.WriteLine("Die Identitätsfunktion gibt folgende Zahlen zurück:");
        foreach (string zahl in zahlen)
        {
            Console.Write(zahl + " ");
        }
        Console.ReadLine();
    }
}
    }
}
