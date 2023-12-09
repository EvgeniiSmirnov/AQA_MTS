namespace Homework5Task1.TriangleModel;

// класс отвечает за логику создания треугольников
public class CreateTriangle : Triangle
{
    public CreateTriangle(double cathetus1, double cathetus2, double hypotenuse) : base(cathetus1, cathetus2, hypotenuse)
    {
    }

    // определяем тип треугольника по соотношению сторон
    public Triangle GetTriangleType()
    {
        // равностронний (все стороны равны)
        if (sideA == sideB && sideA == sideC)
        {
            return new EquilateralTreangle(sideA, sideB, sideC);
        }
        // равнобедренный (две строны равны)
        else if (sideA == sideB || sideA == sideC || sideB == sideC)
        {
            return new IsoscelesTriangle(sideA, sideB, sideC);
        }
        // прямоугольный (квадрат гипотенузы равен сумме квадратов катетов)
        else if (Math.Pow(sideC, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2))
        {
            return new RightTriangle(sideA, sideB, sideC);
        }
        // разностроний
        else
        {
            return new ScaleneTriangle(sideA, sideB, sideC);
        }
    }
}