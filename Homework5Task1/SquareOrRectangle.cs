namespace Homework5Task1;

public class SquareOrRectangle : Figure
{
    public SquareOrRectangle(double sideA, double sideB) : base(sideA, sideB)
    {
        this.sideA = sideA;
        this.sideB = sideB;
    }

    public override void CalculateArea()
    {
        // выводим инфо в зависимости от соотношения сторон
        double area = sideA * sideB;
        if (sideA != sideB)
        {
            Console.WriteLine($"Площать прямоугольника со сторонами {sideA}, {sideB} равна " + Math.Round(area, 3));
        }
        else
        {
            Console.WriteLine($"Площать квадрата со сторонами {sideA}, {sideB} равна " + Math.Round(area, 3));
        }
    }
}