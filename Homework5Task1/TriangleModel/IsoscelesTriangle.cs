namespace Homework5Task1.TriangleModel;

// класс равнобедренного треугольника
public class IsoscelesTriangle : Triangle
{
    public IsoscelesTriangle(double cathetus1, double cathetus2, double hypotenuse) : base(cathetus1, cathetus2, hypotenuse)
    {
    }

    public override void CalculateArea()
    {
        double area = sideC * Math.Sqrt(4 * Math.Pow(sideA, 2) - Math.Pow(sideC, 2)) / 4;
        Console.WriteLine($"Площать равнобедренного треугольника со сторонами {sideA}, {sideB}, {sideC} равна " + Math.Round(area, 3));
    }
}