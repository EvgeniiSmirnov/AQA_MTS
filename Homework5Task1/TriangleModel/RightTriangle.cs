namespace Homework5Task1.TriangleModel;

// класс прямоугольного треугольника
public class RightTriangle : Triangle
{
    public RightTriangle(double cathetus1, double cathetus2, double hypotenuse) : base(cathetus1, cathetus2, hypotenuse)
    {
    }

    public override void CalculateArea()
    {
        double area = sideA * sideB / 2;
        Console.WriteLine($"Площать прямоугольного треугольника со сторонами {sideA}, {sideB}, {sideC} равна " + Math.Round(area, 3));
    }
}