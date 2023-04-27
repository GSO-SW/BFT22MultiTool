
using Figgle;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;

namespace ETBFTKlassenBibliothek
{
    internal class Feature3
    {
        internal static void Feature_3()
        {



            double Sicherheit;
            string Stromleiter;
            string Sicherheitsmaßnahmen;
            string DIN;
            string Support;
            string Beenden;
            bool schleife = true;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            do
            {
                Console.Clear();

                Console.WriteLine("Willkomen bei der Elektro-Sicherheits-App");

                Console.WriteLine("Wählen sie das Sicherheits-Thema ihrer Wahl!");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("1.Stromleiter");
                Console.WriteLine("2.Sicherheitsmaßnahmen vor der Arbeit mit Strom");
                Console.WriteLine("3.DIN-Zeichen");
                Console.WriteLine("4.Support");
                Console.WriteLine("5.Beenden");
                Sicherheit = Convert.ToDouble(Console.ReadLine());
                Console.Clear();



                switch (Sicherheit)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Infos über Stromleiter und nicht Stromleiter");
                        Console.WriteLine("Leiter 1. Klasse erfahren durch die elektrische Leitung keine stoffliche Veränderung.\r\n\r\nMetalle, Graphit und einige weitere chemische Verbindungen wie Niob(II)-oxid sind sog. Leiter 1. Klasse. Die Leitfähigkeit von Metallen (z. B. gemessen als spezifischer Widerstand) beruht nicht auf der Anzahl der Elektronen auf ihrer Außenschale (Valenzelektronen), sondern ist in erster Linie durch die Gitterstruktur vorgegeben. Metalle bilden eine Kristallgitterstruktur, in der die Elektronen nur schwach gebunden sind und als Elektronengas angesehen werden können; das heißt, die Elektronen sind mehr oder weniger frei beweglich.\r\n\r\nDer beste elektrische Leiter ist Silber, Kupfer steht ihm kaum nach, ist aber leichter und wesentlich preiswerter. Noch mehr gilt dies für Aluminium, was die beste massenspezifische Leitfähigkeit hat. Daher kommen in der Technik im Wesentlichen Kupfer (Leitungen, Leiterbahnen, Spulen) und Aluminium (Schwingspulen von Lautsprechern) als elektrische Leiter zum Einsatz.\r\n\r\nDie Leitfähigkeit hängt auch von der Materialtemperatur ab. Bei Metallen steigt der spezifische Widerstand mit Temperaturerhöhung geringfügig (siehe Elektrische Leitfähigkeit#Temperaturabhängigkeit); bei Kohle und Halbleitern kann der Widerstand mit Temperaturzunahme auch sinken.\r\n\r\nBei einigen (zum Teil auch isolierenden) Materialien kann bei sehr niedrigen Temperaturen der spezifische Widerstand auf Null springen. Diesen Zustand nennt man Supraleitung.\r\n\r\nQuantenmechanische Betrachtung\r\nWenn man Metalle quantenmechanisch betrachtet (Blochwellenfunktion, Fermi-Dirac-Statistik), ergibt sich, dass die Elektronen nicht jede Energie annehmen können, sondern nur in bestimmten Energiebändern existieren können – die Form dieser Bänder hängt vom Kristallgitter des Materials ab.\r\n\r\nDie Fermi-Energie (die Energie des energiereichsten Elektrons bei der Temperatur 0 Kelvin) ermöglicht eine Unterscheidung:\r\n\r\nWenn die Fermi-Energie in einem erlaubten Band (Leitungsband) liegt, spricht man von einem Leiter.\r\nLiegt die Fermi-Energie zwischen den erlaubten Bändern, ist es ein\r\nIsolator, wenn der energetische Abstand zwischen dem Valenzband und dem Leitungsband groß gegenüber der thermischen Energie ist;\r\nsonst ist es ein Halbleiter.\r\nHalbleiter sind eine Sonderform: Im reinen Zustand können ihre Kristallgitter stabile Elektronenbindungen aufbauen. Die Elektronen können bei höherer Temperatur in ein Leitungsband aufsteigen; daher leiten Halbleiter im Vergleich zu Metallen bei höheren Temperaturen besser.\r\n\r\nEin interessanter Effekt bei Halbleitern ist die Löcherleitung (auch Fehlstellenleitung): Das in das Leitungsband aufgestiegene Elektron hinterlässt ein Loch in der Bindung, das sich ähnlich einem Elektron mit positiver Ladung verhält und auch zur Leitfähigkeit beiträgt.\r\n\r\nIn Halbleiter können auch noch Fremdatome eingebracht werden – man spricht dann von Dotierung. Die Fremdatome dienen entweder dazu, zusätzliche Elektronen einzubringen – man spricht dann von n-Dotierung (z. B. Stickstoff in Siliciumkristall) – oder enthalten weniger Elektronen, um Löcher einzubringen, was p-Dotierung genannt wird (z. B. Bor in Siliciumkristall).\r\n\r\nModelle\r\nDrude-Theorie\r\nSommerfeld-Theorie\r\nBloch-Theorie\r\nSupraleitung\r\nSupraleitung kann bei tiefen Temperaturen auftreten. Dabei springt der Widerstand des supraleitenden Materials unterhalb einer Grenztemperatur auf Null, was quantenmechanisch erklärt werden kann. Diese Grenztemperatur ist von der Legierung abhängig: Während die ersten untersuchten Supraleiter Temperaturen in der Nähe des absoluten Nullpunktes benötigten, sind heute auch sogenannte Hochtemperatur-Supraleiter bekannt, bei denen dieser Effekt genauso bei höheren Temperaturen auftritt. Es handelt sich dabei aber noch immer um sehr niedrige Temperaturen (unter −130 °C).\r\n\r\nAnwendungen\r\nfür hochempfindliche Sensoren für elektromagnetische Felder\r\nzum Vermindern der Widerstandsverluste in elektrischen Anlagen\r\nverlustfreier Transport von Elektrizität" +
                            "Leiter 2. Klasse werden durch den Leitungsvorgang stofflich verändert.\r\n\r\nSogenannte Ionenleiter sind Leiter 2. Klasse. Die Leitfähigkeit entsteht durch Dissoziation (Aufspaltung) der (ionischen) Kristallgitterstruktur unter Bildung von elektrisch geladenen, beweglichen Ionen im sogenannten Elektrolyt. Dies kann durch Auflösen in einem polaren Lösungsmittel (wie Wasser) oder durch Schmelzen geschehen.\r\n\r\nKlassisches Beispiel sind Salzlösungen. Lösliche Salze werden beim Lösungsvorgang in solvatisierte (als vom Lösungsmittel umgebende) positive und negative Ionen zerlegt; diese bewirken die Leitfähigkeit. Die positiven Ionen wandern dabei in Richtung der negativen Kathode und werden daher Kationen genannt; die negativen Anionen wandern zur positiven Anode. An den Elektroden werden die jeweiligen Ionen durch Elektronenübertritt entladen. Das kann zum Beispiel zur galvanischen Abscheidung von Metall, zum Freiwerden von Chlor (aus Natriumchlorid) oder zur Elektrolyse von Wasser zu Wasserstoff und Sauerstoff verwendet werden.\r\n\r\nSiehe auch: Elektrochemische Spannungsreihe\r\nBei höheren Temperaturen (oberhalb ca. 600 °C) wird Glas (auch) als Ionenleiter elektrisch leitfähig. Dies wird z. B. in entsprechenden Schmelzöfen genutzt, indem nach konventioneller Aufheizung die Glasschmelze dann direkt durch Elektroden, die eingetaucht werden, – also durch den Stromfluss – beheizt wird." +
                            "Wärmeleiter\r\nDie Wärmeleitung ist einer von drei Mechanismen, in denen thermische Energie transportiert werden kann. (Die beiden anderen Möglichkeiten sind Strahlung und Konvektion (Strömung).)\r\n\r\nIn Festkörpern erfolgt der Wärmetransport durch die Ausbreitung von Gitterschwingungen. Eine gute Ausbreitungsmöglichkeit für diese anregenden Schwingungen bieten Leitungselektronen, daher sind elektrische Leiter, insbesondere Metalle, auch gute Wärmeleiter (Wiedemann-Franzsches Gesetz). Die Behandlung dieses Phänomens erfolgt in der Regel zweckmäßigerweise im Modell eines freien oder quasifreien Elektronengases (also von Elektronen, die sich in guter Näherung annähernd frei im Festkörper bewegen können, vergleichbar der Beweglichkeit eines Gases (Drude-Theorie, Sommerfeld-Theorie)). Da bei dieser Leitung die Elektronen bewegt werden, entsteht auch ein Stromfluss (Seebeck-Effekt).\r\n\r\nIn elektrischen Isolatoren wird die Wärme im Wesentlichen durch Gitterschwingungen (Phononen) übertragen. Die Wärmeleitfähigkeit hängt daher von der Schallgeschwindigkeit ab.\r\n\r\nIn Halbleitern treten beide Effekte auf.\r\n\r\nGute Wärmeleiter sind: Metalle.\r\nSchlechte Wärmeleiter sind: Holz, Kunststoffe, Salze.\r\n\r\nEntgegen allgemeiner Annahme ist Wasser ein schlechter Wärmeleiter. Wesentlichen Beitrag zum Wärmetransport liefert hier, im Gegensatz zu Festkörpern, die Konvektion." +
                            "Hochfrequenz- und Mikrowellenleiter\r\nEin bekannter Wellenleiter für hochfrequente elektromagnetische Wellen ist das Koaxialkabel.\r\n\r\nDer Wellenleiter für Mikrowellen nützt aus, dass die Wellen Ströme induzieren. Sie bestehen in der Regel aus einem metallischen Rohr (rund oder auch rechteckig), dessen Durchmesser etwas größer als die halbe Wellenlänge der zu transportierenden Welle ist.\r\n\r\nHohlleiter\r\n→ Hauptartikel: Hohlleiter\r\nEin Hohlleiter ist ein Wellenleiter für elektromagnetische Wellen vorwiegend im Zentimeter-Wellenbereich (3 bis 30 GHz). Als Hohlleiter bezeichnet man runde oder rechteckige Metallrohre, in denen sich derart hohe Frequenzen im Gegensatz zu Kabeln sehr verlustarm übertragen lassen.\r\n\r\nLicht\r\nOptische Leiter bzw. genauer: optische Wellenleiter gibt es in zwei Bauformen:\r\n\r\neindimensional:\r\nEin Beispiel für solche sind als Lichtwellenleiter dienende Glasfasern. Bei konventionellen Glasfasern erfolgt die Lichtleitung mit Hilfe der Totalreflexion; bei einigen modernen Varianten wird das Licht stattdessen mit Hilfe von photonischen Kristallen geführt.\r\nzweidimensional:\r\nEin Beispiel sind hier planare Wellenleiter. Diese werden z. B. in Halbleiterlasern eingesetzt." +
                            "");
                        Console.ReadKey(); Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Sicherheitsmaßnahmen vor der Arbeit mit Strom");
                        Console.WriteLine("Sicherheitsregel: Freischalten\r\nAn erster Stelle steht immer das Freischalten der elektrischen Anlage, und zwar allseitig und allpolig. Das ist nötig, weil Spannung von mehreren Seiten an die Arbeitsstelle gelangen kann – zum Beispiel über Messleitungen oder Wechselschaltungen.\r\n\r\nÜbernehmen Sie das Freischalten immer selbst, damit Sie die größtmögliche Sicherheit haben. Sollte das nicht möglich sein, so lassen Sie sich schriftlich oder mündlich bestätigen, dass die Anlage freigeschaltet wurde.\r\n\r\nSicherheitsregel: Gegen Wiedereinschalten sichern\r\nSichern Sie die Anlage unmittelbar nach dem Freischalten gegen das Wiedereinschalten. Den besten Schutz bietet hier ein Vorhängeschloss am Leitungsschutzschalter, das nur Sie wieder entsperren können. Weitere Methoden sind Klebefolien oder ein Verbotsschild.\r\n\r\nBei einem Verbotsschild sollten Sie besonders darauf achten, dass es eindeutig dem Stromkreis zugeordnet ist und nicht herunterfallen kann. Setzen Sie zusätzlich immer noch auf eine weitere Schutzmaßnahme. Herausnehmbare Sicherungen nehmen Sie am besten mit und setzen stattdessen ein Sperrelement ein.\r\n\r\nSicherheitsregel: Spannungsfreiheit feststellen\r\nAuch nach dem Freischalten und Sichern gegen Wiedereinschalten kann noch Spannung anstehen, zum Beispiel wenn eine Ersatzstromversorgung anspringt oder weil Sie eine Leitung verwechselt haben. Deshalb sollten Sie unbedingt die Spannungsfreiheit der Anlage feststellen. Dies darf nur von einer Elektrofachkraft oder einer elektrotechnisch unterwiesenen Person mit geeigneten Geräten durchgeführt werden.\r\n\r\nVerwenden Sie dazu immer zweipolige Spannungsprüfer. Kontrollieren Sie die Spannungsprüfer vor der Verwendung und stellen Sie die Spannungsfreiheit allpolig, also an jedem Leiter, fest. Dass eine Leitung spannungsfrei ist, zeigt Ihnen der Spannungsprüfer über ein optisches oder akustisches Signal an.\r\n\r\nBeachten Sie auch Anwendungsbeschränkungen oder andere Hinweise in der Bedienungsanleitung oder auf dem Typenschild des Spannungsprüfers. Wenn ein Gerät nicht für die Verwendung im Freien zugelassen ist, ist es dort auch nicht sicher – und kann Sie in große Gefahr bringen\r\n\r\nSicherheitsregel: Erden und kurzschließen\r\nDie vierte Sicherheitsregel „Erden und kurzschließen“ sollte immer in dieser Reihenfolge ausgeführt werden. Verbinden Sie die Anlage also zuerst mit der Erdungsanlage oder dem Erder, danach kommt dann das Kurzschließen.\r\n\r\nBei Hochspannungsanlagen erfolgt das Erden und Kurzschließen an der Arbeitsstelle und an der Ausschaltstelle.\r\nBei Niederspannungsanlagen mit einer Nennspannung bis 1.000 Volt ist das Erden und Kurzschließen nicht nötig, wenn Sie die Sicherheitsregeln 1 bis 3 eingehalten haben.\r\nAusnahmen bilden Freileitungen: Hier muss das Erden und Kurzschließen erfolgen, und zwar an der Arbeitsstelle.\r\nSicherheitsregel: Benachbarte, unter Spannung stehende Teile abdecken oder abschranken\r\nAuch wenn Sie die Sicherheitsregeln 1 bis 4 ausgeführt haben, besteht immer noch die Gefahr, dass Sie beim Arbeiten unter Spannung stehende Teile in der Nähe ihrer Arbeitsstelle berühren – entweder direkt oder mit einer Leiter, Werkzeugen o.Ä. Um sich davor zu schützen, müssen Sie diese Teile abdecken oder abschranken.\r\n\r\nEntscheiden Sie sich für eine Abdeckung, so müssen Sie sicherstellen, dass diese nicht verrutschen kann. Beim Schutz durch Abstand muss der Arbeitsbereich deutlich gekennzeichnet sein, zum Beispiel durch eine Absperrkette mit Warnhinweis.\r\n\r\nSchützen Sie zusätzlich auch Ihren Körper, zum Beispiel mit einem Helm mit Gesichtsschutz oder hochisolierten Handschuhen.");
                        Console.ReadKey(); Console.ForegroundColor = ConsoleColor.Magenta;
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Die DIN");
                        Console.WriteLine("Wer ist DIN?\r\nDas Deutsche Institut für Normung e.V. (DIN) ist die unabhängige Plattform für Normung und Standardisierung in Deutschland und weltweit. Gemeinsam mit Wirtschaft, Wissenschaft, öffentlicher Hand und Zivilgesellschaft trägt DIN wesentlich dazu bei, Zukunftsfelder zu erschließen. Als Mitgestalter des digitalen und grünen Wandels leistet DIN einen wichtigen Beitrag bei der Lösung der aktuellen Herausforderungen und ermöglicht, dass sich neue Technologien, Produkte und Verfahren am Markt und in der Gesellschaft etablieren.\r\n\r\nRund 36.000 Expert*innen aus Wirtschaft und Forschung, von Verbraucherseite und der öffentlichen Hand bringen ihr Fachwissen in den Normungsprozess ein, den DIN als privatwirtschaftlich organisierter Projektmanager steuert. Die Ergebnisse sind marktgerechte Normen und Standards, die den weltweiten Handel fördern und der Rationalisierung, der Qualitätssicherung, dem Schutz der Gesellschaft und Umwelt sowie der Sicherheit und Verständigung dienen.\r\n\r\nDIN wurde 1917 gegründet und feierte 2017 sein 100-jähriges Bestehen." +
                            "Was ist eine Norm?\r\nEine Norm ist ein Dokument, das Anforderungen an Produkte, Dienstleistungen oder Verfahren festlegt. Sie schafft somit Klarheit über deren Eigenschaften, erleichtert den freien Warenverkehr und fördert den Export. Sie unterstützt die Rationalisierung und Qualitätssicherung in Wirtschaft, Technik, Wissenschaft und Verwaltung. Sie dient der Sicherheit von Menschen und Sachen sowie der Qualitätsverbesserung in allen Lebensbereichen. Der volkswirtschaftliche Nutzen beträgt rund 17 Milliarden Euro jährlich.\r\n\r\nEines der bekanntesten Beispiele für Normen sind sicherlich die DIN-Formate. Jeder kennt DIN A4. Die Norm sorgt unter anderem dafür, dass Papier in jeden Drucker, Kopierer oder Hefter passt. Die Formate wurden bereits im Jahr 1922 als DIN 476 veröffentlicht. und sind heute ein internationaler Klassiker: DIN EN ISO 216.\r\n\r\nAktuell bilden rund 34.000 Normen das Deutsche NormenWerk. Diese werden über den Beuth Verlag veröffentlicht. Ob Kegelstift oder Babyschnuller, Treppe oder Schraube, Leiter oder Zahnbürste - fast nichts in unserem Alltag ist nicht von Normen erfasst.\r\n\r\nNormen und Standards zum Anfassen finden Sie in unserer interaktiven Ausstellung." +
                            "Wie entsteht eine DIN-Norm?\r\nNormen entwickeln diejenigen, die sie später anwenden. Damit der Markt die Normen akzeptiert, sind eine breite Beteiligung, Transparenz und Konsens Grundprinzipien bei DIN. Jeder kann einen Antrag auf Normung stellen. Alle an einem Thema interessierten Kreise erhalten die Möglichkeit, mitzuwirken und ihre Expertise einzubringen. Vor der Verabschiedung werden die Norm-Entwürfe öffentlich gemacht und zur Diskussion gestellt. Die beteiligten Expert*innen müssen sich über die endgültigen Inhalte grundsätzlich einig sein. Spätestens alle fünf Jahre werden Normen auf den Stand der Technik hin überprüft." +
                            "Sind Normen Pflicht?\r\nDie Anwendung von DIN-Normen ist grundsätzlich freiwillig. Erst wenn Normen zum Inhalt von Verträgen werden oder wenn der Gesetzgeber ihre Einhaltung zwingend vorschreibt, werden Normen bindend. Zwar stellen sie im Fall einer möglichen Haftung keinen Freibrief dar. Aber wer DIN-Normen – als anerkannte Regeln der Technik – anwendet, kann ein korrektes Verhalten einfacher nachweisen." +
                            "Was ist eine DIN SPEC?\r\nIm Gegensatz zu einer Norm wird der Inhalt einer DIN SPEC durch ein temporär zusammengestelltes Gremium erstellt. Konsens und die Einbeziehung aller interessierten Kreise sind nicht zwingend erforderlich. DIN SPEC sind als Ergebnisse von Standardisierungsprozessen bewährte strategische Mittel, um innovative Lösungen schnell und unkompliziert am Markt zu etablieren und zu verbreiten. Die DIN SPEC ist der kürzeste Weg von der Forschung zum Produkt. Ein solcher Standard kann innerhalb weniger Monate unkompliziert in kleinen Arbeitsgruppen erarbeitet werden. Er fördert den Austausch mit anderen Marktteilnehmern. DIN sorgt dafür, dass die DIN SPEC nicht mit bestehenden Normen kollidiert, und veröffentlicht sie – auch international. Die DIN SPEC ist ein hochwirksames Marketinginstrument, das dank der anerkannten Marke DIN für eine große Akzeptanz bei Kunden und Partnern sorgt. Eine DIN SPEC kann die Basis für die Erarbeitung einer Norm sein." +
                            "");
                        Console.ReadKey(); Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Support");
                        Console.WriteLine("Bitte rufe sie die gennante Nummer bei fragen oder problemen an !--> 0178 3321444 <--!"); Console.ForegroundColor = ConsoleColor.Blue;
                        Console.ReadKey();
                        Console.Clear();
                        schleife = true;
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Falsche eingabe!"); Console.ForegroundColor = ConsoleColor.Red;
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (schleife == true);

        }

    }
}