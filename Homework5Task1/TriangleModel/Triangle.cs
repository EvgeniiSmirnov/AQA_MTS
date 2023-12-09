namespace Homework5Task1.TriangleModel;

// родительский класс для всех треугольников
using Homework5Task1;

public abstract class Triangle : Figure
{
    public Triangle(double cathetus1, double cathetus2, double hypotenuse)
    {
        this.sideA = cathetus1;
        this.sideB = cathetus2;
        this.sideC = hypotenuse;
    }

    public override void CalculateArea()
    {
        throw new NotImplementedException();
    }
}