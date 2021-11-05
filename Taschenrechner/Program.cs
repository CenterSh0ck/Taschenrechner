class Programm
{
    public static void Main(string[] args)
    {
        // Als Benutzer möchte ich zwei Zahlen eingeben,
        // um deren Summe berechnen zu lassen. 
        // Eingabe und Ausgabe
        Console.WriteLine("Bitte ersten Summanden eingeben:");
        Console.WriteLine("********************************");
        string zahl1 = Console.ReadLine();
        Console.WriteLine("Bitte zweiten Summanden eingeben:");
        Console.WriteLine("********************************");
        string zahl2 = Console.ReadLine();

        // Konvertierung von Text in Ganzzahlen und GLeitkommazahlen
        double ersterSummand = Convert.ToDouble(zahl1);
        double zweiterSummand = Convert.ToDouble(zahl2);

        // Berechnung ausführen
        double summe = Addiere(ersterSummand, zweiterSummand);
        Console.WriteLine("********************************");
        Console.WriteLine("Die Summe ist: {0}", summe);
        WarteAufBenutzerEingabe();
    }
        // Berechnungen als eigene Methoden
    static double Addiere(double ersterSummand, double zweiterSummand)
    {
        double summe = ersterSummand + zweiterSummand;
        return summe;
    }


    static void WarteAufBenutzerEingabe()
    {
        Console.WriteLine("Zum beenden bitte Return drücken.");
        Console.ReadLine();
    }
 }

