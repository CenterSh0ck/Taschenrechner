class Programm
{
    public static void Main(string[] args)
    {
        // Als Benutzer möchte ich zwei Zahlen eingeben,
        // um deren Summe berechnen zu lassen. 
        // Eingabe und Ausgabe
        double ersteZahl = 0;
        double zweiteZahl = 0;

        bool eingabeErfolgreich = false;
        while (!eingabeErfolgreich)
        {
            string zahl1 = HoleBenutzerEingabe("Bitte gib die erste Zahl ein: ");
            Console.WriteLine("********************************");
            eingabeErfolgreich = double.TryParse(zahl1, out ersteZahl);
            if (!eingabeErfolgreich)
            {
                Console.WriteLine("Bist du zu doof eine Zahl einzugeben?");
            }
        }

        bool eingabeErfolgreich1 = false;
        while (!eingabeErfolgreich1)
        {
            string zahl2 = HoleBenutzerEingabe("Bitte gib die zweite Zahl ein: ");
            Console.WriteLine("********************************");
            eingabeErfolgreich1 = double.TryParse(zahl2, out zweiteZahl);
            if (!eingabeErfolgreich1)
            {
                Console.WriteLine("Immernoch es muss eine Zahl eingegeben werden!");
            }
        }


        string operation = HoleBenutzerEingabe("Bitte gib die auszuführende Operation ein (+,*,/ oder -): ");
        Console.WriteLine("*******************************************************");

        // Konvertierung von Text in Ganzzahlen und GLeitkommazahlen
        // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.   

        // Berechnung ausführen
        var resultat = Berechnung(ersteZahl, zweiteZahl, operation);

        // Ausgabe
        HoleBenutzerEingabe("Zum beenden bitte Return drücken.");

        // Berechnung als eigene Methode 
        double Berechnung(double ersteZahl, double zweiteZahl, string operation)
        {
            resultat = 0;

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
                    Console.WriteLine("Das Produkt ist: {0}", resultat);
                    break;
                case "/":
                    resultat = quotientenwert(ersteZahl, zweiteZahl);
                    Console.WriteLine("Der Quotientwert ist: {0}", resultat);
                    break;
                default:
                    Console.WriteLine("Keine Gültiger Operator!!!");
                    break;
            }
            return resultat;
        }

        // Methode zur Ausgabe des eingegebenen Strings als Zahl
        static string HoleBenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string zahl1 = Console.ReadLine();

            return zahl1;
        }

        // Methode(Addition)
        static double Addiere(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;

            return summe;

        }

        // Methode(Subtraktion)
        static double Subtrahiere(double minuend, double subtrahent)
        {
            var differenz = minuend - subtrahent;

            return differenz;
        }

        // Methode(Multiplikation)
        static double Multipliziere(double produkt, double produkt2)
        {
            double produktfaktor = produkt * produkt2;

            return produktfaktor;
        }

        // Methode(Division)
        static double quotientenwert(double divident, double divisor)
        {
            double quotientenwert = divident / divisor;

            return quotientenwert;
        }
    }
}

