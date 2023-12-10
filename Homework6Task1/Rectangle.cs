namespace Homework6Task1;

public class Rectangle : Triangle
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public Rectangle(double sideA) : base(sideA) { }

    public Rectangle(double sideA, double sideB) : base(sideA, sideB)
    {
        SideA = sideA;
        SideB = sideB;
    }

    public override double GetArea()
    {
        return SideA * SideB;
    }
    public override double GetPerimeter()
    {
        return SideA + SideB;
    }
}