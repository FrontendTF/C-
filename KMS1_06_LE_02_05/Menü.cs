using System;
using System.Collections.Generic;
using GeometrischeFigurenBerechnung;

class Menü
{
    private List<GeometrischeFigur> figurenListe = new List<GeometrischeFigur>();

    public void Start()
    {
        ///<summary>
        /// Menü + automatische Speicherung der Objekte bei der Erstellung
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Wählen Sie eine geometrische Figur:");
            Console.WriteLine("1 für Kreis");
            Console.WriteLine("2 für Rechteck");
            Console.WriteLine("3 für Dreieck");
            Console.WriteLine("4 für Beenden");
            string auswahl = Console.ReadLine();

            if (auswahl == "4")
            {
                Environment.Exit(0);
            }

            GeometrischeFigur figur = null;

            switch (auswahl)
            {
                case "1":
                    figur = FigurenErstellung.ErstelleKreis();
                    break;
                case "2":
                    figur = FigurenErstellung.ErstelleRechteck();
                    break;
                case "3":
                    figur = FigurenErstellung.ErstelleDreieck();
                    break;
                default:
                    Console.WriteLine("Ungültige Auswahl, drücken Sie eine Taste für eine erneute Eingabe.");
                    Console.ReadKey();
                    continue;
            }

            // Speicherung der Objekte/Instanzen
            if (figur != null)
            {
                figurenListe.Add(figur);
                Console.WriteLine($"Figur: {figur.GetType().Name}, Farbe: {figur.Farbe}");
                Console.WriteLine($"Fläche: {figur.BerechneFlaeche():F2} m²");
                Console.WriteLine($"Umfang: {figur.BerechneUmfang():F2} m");
                /// Readkey eingebaut um das Ergebnis anzusehen können, 
                /// ohne dem würde er im Menü mit continue dem user keine Zeit geben sich die Ergebnise anzusehen
                Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren...");
                Console.ReadKey();
            }
        }
        ///<summary/>

        Console.Clear();
    }
}
