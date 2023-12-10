namespace Homework6Task1;

public class Triangle : Shape
{
    public double Catetus1 { get; set; }
    public double Catetus2 { get; set; }
    public double Hipotenuse { get; set; }

    public Triangle(double catetus1) => Catetus1 = catetus1;

    public Triangle(double catetus1, double catetus2) : this(catetus1) => Catetus2 = catetus2;

    public Triangle(double catetus1, double catetus2, double hipotenuse) : this(catetus1, catetus2) => Hipotenuse = hipotenuse;

    public override double GetArea()
    {
        // рассчитываем площадь по формуле Герона через полупериметр
        double semiperimeter = GetPerimeter() / 2;
        double area = Math.Sqrt(semiperimeter * (semiperimeter - Catetus1) * (semiperimeter - Catetus2) * (semiperimeter - Hipotenuse));
        return Math.Round(area, 3);
    }
    public override double GetPerimeter()
    {
        return Catetus1 + Catetus2 + Hipotenuse;
    }
}