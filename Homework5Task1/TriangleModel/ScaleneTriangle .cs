namespace Homework5Task1.TriangleModel;

// класс разностроннего треугольника
internal class ScaleneTriangle : Triangle
{
    public ScaleneTriangle(double cathetus1, double cathetus2, double hypotenuse) : base(cathetus1, cathetus2, hypotenuse)
    {
    }

    public override void CalculateArea()
    {
        // рассчитываем площадь по формуле Герона через полупериметр
        double semiperimeter = (sideA + sideB + sideC) / 2;
        double area = Math.Sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));
        Console.WriteLine($"Площать разностроннего треугольника со сторонами {sideA}, {sideB}, {sideC} равна " + Math.Round(area, 3));
    }
}