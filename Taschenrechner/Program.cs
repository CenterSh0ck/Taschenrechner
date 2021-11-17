class Programm
{
    public static void Main(string[] args)
    {
        // Als Benutzer möchte ich zwei Zahlen eingeben,
        // um deren Summe berechnen zu lassen. 
        // Eingabe und Ausgabe
        string zahl1 = HoleBenutzereingabe("Bitte gib die erste Zahl ein: ");
        Console.WriteLine("********************************");
        string zahl2 = HoleBenutzereingabe("Bitte gib die zweite Zahl ein: ");
        Console.WriteLine("********************************");
        string operation = HoleBenutzereingabe("Bitte gib die auszuführende Operation ein (+,*,/ oder -): ");
        Console.WriteLine("*******************************************************");

        // Konvertierung von Text in Ganzzahlen und GLeitkommazahlen
        // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
        double ersteZahl = Convert.ToDouble(zahl1);
        double zweiteZahl = Convert.ToDouble(zahl2);

        // Berechnung ausführen
        double resultat = 0;
        switch (operation)
        {
            case "+":
                resultat = Addiere(ersteZahl, zweiteZahl);
                Console.WriteLine("Die Summe ist: {0}", resultat);
                break;
            case "-":
                resultat = Subtrahiere(ersteZahl, zweiteZahl);
                Console.WriteLine("Die Differenz ist: {0}", resultat);
                break;
            case "*":
                resultat = Multipliziere(ersteZahl, zweiteZahl);
                Console.WriteLine("Der Produktfaktor ist: {0}", resultat);
                break;
            case "/":
                resultat = quotientenwert(ersteZahl, zweiteZahl);
                Console.WriteLine("Der Quotientwert ist: {0}", resultat);
                break;
            default:
                Console.WriteLine("Keine Gültige Operation!!!");
                break;
        }
        HoleBenutzereingabe("Zum beenden bitte Return drücken.");
    }

        // Methode zur Ausgabe des eingegebenen Strings als Zahl
    static string HoleBenutzereingabe(string ausgabeText)
    {
        Console.Write(ausgabeText);
        string zahl1 = Console.ReadLine();

        return zahl1; 
    }

        // Berechnungen als eigene Methode(Addition)
    static double Addiere(double ersterSummand, double zweiterSummand)
    {
        double summe = ersterSummand + zweiterSummand;
        
        return summe;

    }

        // Berechnung als eigene Methode(Subtraktion)
    static double Subtrahiere(double minuend, double subtrahent)
    {
        double differenz =  minuend - subtrahent;
        
        return differenz;
    }

        // Berechnung als eigene Methode(Multiplikation)
    static double Multipliziere(double produkt, double produkt2)
    {
        double produktfaktor = produkt * produkt2;

        return produktfaktor;
    }

    // Berechnung als eigene Methode(Division)
    static double quotientenwert(double divident, double divisor)
    {
        double quotientenwert = divident / divisor;

        return quotientenwert;
    }
 }

