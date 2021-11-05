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

        // Konvertierung von Text in Ganzzahlen
        int ersteZahl = Convert.ToInt32(zahl1);
        int zweiteZahl = Convert.ToInt32(zahl2);

        // Berechnung ausführen
        int summe = ersteZahl + zweiteZahl;
        Console.WriteLine("********************************");
        Console.WriteLine("Die Summe ist: {0}", summe);
        Console.ReadKey(true);
    }
 }

