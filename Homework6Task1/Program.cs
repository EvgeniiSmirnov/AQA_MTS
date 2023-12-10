/*
Задание 1
Написать иерархию классов «Фигуры».
Фигура -> Треугольник -> Прямоугольник -> Круг.
Реализовать метод подсчета площади и периметра для каждого типа фигуры.
Создать массив из 5 фигур.
Вывести на экран сумму периметра и площади всех фигур в массиве.
*/

using Homework6Task1;

public class Program
{
    public static void Main()
    {

        Shape[] figures =
        {
            new Rectangle(10,10),     // квадрат
            new Rectangle(10,20),     // прямоугольник
            new Triangle(10, 10, 10), // равносторонний треугольник
            new Triangle(10, 10, 15), // равнобедренный треугольник
            new Circle(10)            // круг
        };

        // Вывести на экран сумму периметра и площади всех фигур в массиве.
        double perimeterAndAreaSum = 0;
        foreach (Shape shape in figures)
        {
            perimeterAndAreaSum += shape.GetArea() + shape.GetPerimeter();
        }
        Console.WriteLine(perimeterAndAreaSum);
    }
}