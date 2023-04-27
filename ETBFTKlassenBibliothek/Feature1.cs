{
    string Rechner;
    double Flaeche;
    double Watt;
    double Wirkungsgrad;
    double Sonne;
    double energie;
    bool schleife = true;

    do
    {
        Console.WriteLine("Energie Rechner Solar");
        Console.WriteLine(" ");
        Console.WriteLine("1. Rechner starten");
        Console.WriteLine("2. Information über die einzelnen Werte");
        Console.WriteLine("3. SUPPORT / HILFE");
        Console.WriteLine("4. Beenden");
        Rechner = Convert.ToString(Console.ReadLine());
        Console.Clear();
    switch (Rechner)
    {
        case "1":
            Console.WriteLine("Energie Rechner Solar");
            Console.WriteLine("Geben Sie die Fläche des Solarmoduls ein (in Quadratmetern): ");
            Flaeche = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben Sie die Sonneneinstrahlung ein (in Watt pro Quadratmeter): ");
            Watt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben Sie den Wirkungsgrad des Solarpanels ein(als Dezimalzahl): ");
            Wirkungsgrad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben Sie die Zeit im Sonnenlicht ein (in Stunden):");
            Sonne = Convert.ToDouble(Console.ReadLine());

            energie = Flaeche * Watt * Wirkungsgrad * Sonne;
            Console.WriteLine($"So viel Energie wird produktziert: {energie}");

            break;

        case "2":
            Console.WriteLine("Information über die einzelnen Werte");
            Console.WriteLine(" ");
            Console.WriteLine("\"Geben sie die Fläche des Solar\" bedeutet, dass Sie die Größe des Solarmoduls angeben sollen. Um die Fläche des Solarmoduls zu bestimmen, müssen Sie die Breite und Länge des Moduls messen und dann diese Werte multiplizieren.");
            Console.WriteLine(" Zum Beispiel, wenn das Solarmodul 1 Meter breit ist und 1,5 Meter lang ist, beträgt die Fläche 1,5 Quadratmeter (1m x 1,5m = 1,5m²). ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\"Geben Sie die Sonneneinstrahlung ein\" Es gibt jedoch mehrere Möglichkeiten, die Sonneneinstrahlung in Watt pro Quadratmeter (W/m²) zu schätzen, wie zum Beispiel durch die Verwendung von Solarmessgeräten oder mithilfe von Sonnenstrahlungsdaten, die von lokalen Wetterstationen oder Online-Quellen zur Verfügung gestellt werden. ");
            Console.WriteLine("Ein Beispiel für eine grobe Schätzung der Sonneneinstrahlung ist die Annahme, dass die durchschnittliche Sonneneinstrahlung auf der Erde bei klarem Himmel bei senkrechtem Einfall etwa 1000 W/m² beträgt.);");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\"Geben Sie die Zeit im Sonnenlicht ein\" Um die Zeit im Sonnenlicht grob zu berechnen, können Sie die Differenz zwischen der Sonnenaufgangszeit und der Sonnenuntergangszeit an Ihrem Standort verwenden.");
            Console.WriteLine(" Online-Tools wie \"SunCalc.net\" können Ihnen genaue Informationen zu den Sonnenzeiten geben. Beachten Sie jedoch, dass dies nur eine Schätzung ist und von der Jahreszeit und Ihrem geografischen Standort abhängt. ");
            Console.ReadKey();
            Console.Clear();
                break;

        case "3":
            Console.WriteLine("Wenn Sie Hilfe brauchen Rufen sie diese Nummer an: !-> +49 176 21582787 <-!");
            Console.WriteLine("Oder an diese E-Mail !-> can.duman1@outlook.de <-!");
            Console.ReadKey();
            Console.Clear();
            schleife = true;
            break;
        case "4":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Falsche eingabe!");
            Console.ReadKey();
            Console.Clear();
            break;
        }
    } while (schleife == true);

}




    
