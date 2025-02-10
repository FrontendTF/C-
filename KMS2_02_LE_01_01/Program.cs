using System;
using System.Collections.Generic;

class Program
{
    // Definition des Delegatentypen
    public delegate bool FilterDelegate(int number);

    static void Main()
    {
        // Beispiel-Liste von Ganzzahlen
        List<int> numbers = new List<int> { -5, 10, -3, 7, -2, 8, 0, 15, -1, 3, -7, 6 };

        // Delegate für die Bedingung (positive Zahl)
        FilterDelegate isPositive = IsPositive;

        // Filtert die Liste
        List<int> filteredList = FilterList(numbers, isPositive);

        // Ausgabe der gefilterten Liste
        Console.WriteLine("Gefilterte Liste (nur positive Zahlen):");
        foreach (int number in filteredList)
        {
            Console.WriteLine(number);
        }
    }

    // Methode, die die Liste filtert mit Filter
    public static List<int> FilterList(List<int> numbers, FilterDelegate filter)
    {
        List<int> filteredList = new List<int>();

        foreach (int number in numbers)
        {
            if (filter(number))
            {
                filteredList.Add(number);
            }
        }

        return filteredList;
    }

    // Methode die überprüft ob eine Zahl positiv ist
    public static bool IsPositive(int number)
    {
        return number > 0;
    }
}
