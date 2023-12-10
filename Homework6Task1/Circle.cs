namespace Homework6Task1;

public class Circle : Rectangle
{
    public double Radius { get; set; }

    public Circle(double radius) : base(radius) => Radius = radius;

    public override double GetArea()
    {
        return Math.Round(Math.PI * Math.Pow(Radius, 2), 3);
    }
    public override double GetPerimeter()
    {
        return Math.Round(2 * Math.PI * Radius, 3);
    }
}