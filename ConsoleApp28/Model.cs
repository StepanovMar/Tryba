public class Pipe
{
    public double InnerRadius { get; set; }
    public double OuterRadius { get; set; }

    public double CalculateArea()
    {
        double innerArea = Math.PI * Math.Pow(InnerRadius, 2);
        double outerArea = Math.PI * Math.Pow(OuterRadius, 2);
        return outerArea - innerArea;
    }
}