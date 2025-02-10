using System;

public delegate int MyDelegate(int number);  // Delegatentyp mit einem Parameter und einem Rückgabewert

class Program
{
    static void Main()
    {
        // Delegaten erstellen
        MyDelegate myDelegate = null;

        // Hinzufügen von Methoden zum Delegaten
        myDelegate += MultiplyBy2;
        myDelegate += MultiplyBy3;
        myDelegate += MultiplyBy4;

        // Zahl eingeben
        Console.WriteLine("Bitte geben Sie eine Ganzzahl ein: ");
        string input = Console.ReadLine();
        int zahl;
        while (!int.TryParse(input, out zahl))
        {
            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Ganzzahl ein: ");
            input = Console.ReadLine();
        }

        // Variable zur Speicherung des Gesamtergebnisses
        int sum = 0;

        // Aufrufen des Multicast Delegaten mit GetIn.. um alle Delegaten zu erhalten
        foreach (MyDelegate del in myDelegate.GetInvocationList())
        {
            // Der Wert von 'zahl' wird als Parameter 'number' an die Methode übergeben
            sum += del(zahl);
        }

        // Gesamtergebnis einschließlich der ursprünglichen Zahl
        int result = sum;

        // Summe aller Methoden
        Console.WriteLine("Das Ergebnis ist: " + (result));
        Console.WriteLine("Die ausgewählte Zahl ist: " + zahl);
    }

    // Methode 1: *2
    public static int MultiplyBy2(int number)
    {
        int result = number * 2;
        Console.WriteLine($"Methode 1: {number} x 2 = {result}");
        return result;
    }

    // Methode 2: *3
    public static int MultiplyBy3(int number)
    {
        int result = number * 3;
        Console.WriteLine($"Methode 2: {number} x 3 = {result}");
        return result;
    }

    // Methode 3: *4
    public static int MultiplyBy4(int number)
    {
        int result = number * 4;
        Console.WriteLine($"Methode 3: {number} x 4 = {result}");
        return result;
    }
}
