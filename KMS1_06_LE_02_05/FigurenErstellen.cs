using System;
using GeometrischeFigurenBerechnung;

public static class FigurenErstellung
{
    /// <summary>
    /// Methoden die zur Figurerstellung dienen  
    public static Kreis ErstelleKreis()
    {
        try
        {
            Kreis kreis = new Kreis();
            kreis.Farbe = EingabeFarbe("Geben Sie die Farbe des Kreises ein:");
            kreis.Radius = EingabeDouble("Geben Sie den Radius des Kreises ein:");

            return kreis;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Bei der Kreiserstellung ist ein Fehler aufgetreten");
            return null;
        }
    }

    public static Rechteck ErstelleRechteck()
    {
        try
        {
            Rechteck rechteck = new Rechteck();
            rechteck.Farbe = EingabeFarbe("Geben Sie die Farbe des Rechtecks ein:");
            rechteck.Laenge = EingabeDouble("Geben Sie die Länge des Rechtecks ein:");
            rechteck.Breite = EingabeDouble("Geben Sie die Breite des Rechtecks ein:");

            return rechteck;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Bei der Rechteckerstellung ist ein Fehler aufgetreten");
            return null;
        }
    }

    public static Dreieck ErstelleDreieck()
    {
        try
        {

            Dreieck dreieck = new Dreieck();
            dreieck.Farbe = EingabeFarbe("Geben Sie die Farbe des Dreiecks ein:");
            dreieck.Basis = EingabeDouble("Geben Sie die Basis des Dreiecks ein:");
            dreieck.Hoehe = EingabeDouble("Geben Sie die Höhe des Dreiecks ein:");
            dreieck.SeiteA = EingabeDouble("Geben Sie die Seite A des Dreiecks ein:");
            dreieck.SeiteB = EingabeDouble("Geben Sie die Seite B des Dreiecks ein:");

            return dreieck;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Bei der Dreieckerstellung ist ein Fehler aufgetreten");
            return null;
        }
    }
    /// </summary>

    ///<summary>
    ///Methoden zur Überprüfung der Eingabe

    // Methode zur Eingabenüberprüfung bei den Zahlen
    private static double EingabeDouble(string aufforderung)
    {

        double wert;
        while (true)
        {
            Console.WriteLine(aufforderung);
            try
            {
                if (double.TryParse(Console.ReadLine(), out wert) && wert >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine positive gültige Zahl oder Kommazahl ein.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ein unerwarteter Fehler ist aufgetreten.");
            }
        }
        return wert;
    }

    // Methode zur Eingabeüberprüfung bei Farben (nur Buchstaben)
    private static string EingabeFarbe(string aufforderung)
    {
        while (true)
        {
            Console.WriteLine(aufforderung);
            string eingabe = Console.ReadLine();
            if (!string.IsNullOrEmpty(eingabe) && eingabe.All(char.IsLetter))
            {
                return eingabe;
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie nur Buchstaben ein.");
            }
        }
    }
    ///</summary>
}
