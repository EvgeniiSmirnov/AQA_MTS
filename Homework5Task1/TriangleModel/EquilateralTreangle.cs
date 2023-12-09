namespace Homework5Task1.TriangleModel;

// класс равностороннего треугольника
public class EquilateralTreangle : Triangle
{
    public EquilateralTreangle(double cathetus1, double cathetus2, double hypotenuse) : base(cathetus1, cathetus2, hypotenuse)
    {
    }

    public override void CalculateArea()
    {
        double area = Math.Pow(sideA, 2) * Math.Sqrt(3) / 4;
        Console.WriteLine($"Площать равностороннего треугольника со сторонами {sideA}, {sideB}, {sideC} равна " + Math.Round(area, 3));
    }
}