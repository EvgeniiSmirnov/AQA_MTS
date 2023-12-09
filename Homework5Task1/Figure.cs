namespace Homework5Task1;

// родительский класс для всех фигур
public abstract class Figure
{
    public double sideA;
    public double sideB;
    public double sideC;

    public Figure()
    {
    }

    public Figure(double sideA, double sideB) : this()
    {
        this.sideA = sideA;
        this.sideB = sideB;
    }

    public abstract void CalculateArea();
}