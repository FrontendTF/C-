namespace GeometrischeFigurenBerechnung
{
    // Abstrakte Klasse Geometrische Figuren 
    public abstract class GeometrischeFigur
    {
        public string Farbe { get; set; }

        public abstract double BerechneFlaeche();
        public abstract double BerechneUmfang();
    }

    // Kreis
    // Klasse für Kreise erbt von GemoetrischerFigur und überrschreibt BerechneFläche und BerechneUmfang
    public class Kreis : GeometrischeFigur
    {
        public double Radius { get; set; }

        public override double BerechneFlaeche()
        {
            return Math.PI * Radius * Radius;
        }

        public override double BerechneUmfang()
        {
            return 2 * Math.PI * Radius;
        }
    }

    // Rechteck
    // Klasse von Rechtecken erbt von GemoetrischerFigur und überrschreibt BerechneFläche und BerechneUmfang
    public class Rechteck : GeometrischeFigur
    {
        public double Laenge { get; set; }
        public double Breite { get; set; }

        public override double BerechneFlaeche()
        {
            return Laenge * Breite;
        }

        public override double BerechneUmfang()
        {
            return 2 * (Laenge + Breite);
        }
    }

    // Dreieck
    // Klasse von Dreiecken erbt von GemoetrischerFigur und überrschreibt BerechneFläche und BerechneUmfang
    // Funktioniert nur dann richtig wenn man die richtigen Werte eingibt da es ja Unterschiedliche Dreiecksformen/formeln gibt
    public class Dreieck : GeometrischeFigur
    {
        public double Basis { get; set; }
        public double Hoehe { get; set; }
        public double SeiteA { get; set; }
        public double SeiteB { get; set; }

        public override double BerechneFlaeche()
        {
            return 0.5 * Basis * Hoehe;
        }

        public override double BerechneUmfang()
        {
            return Basis + SeiteA + SeiteB;
        }
    }
}
