/*
Задание 1:
Создать класс для подсчета площади треугольников
реализовать классы для равнобедренного, равностороннего, прямоугольного и разностороннего треугольника
для каждого использовать свою формулу для подсчета площади
площадь разностороннего треугольника считаем по формуле Герона

Создать отдельный класс который будет отвечать за логику создания треугольников. В нем вернуть нужный объект треугольника проверив его стороны
добавить класс квадрат и прямоугольник и логику подсчета площади для него
добавить класс для реализации иерархии фигур
создавь массив квадратов, прямоугольников и треугольников и вывести их площади
*/

using Homework5Task1;
using Homework5Task1.TriangleModel;

public class Program
{
    public static void Main()
    {
        Figure[] figures = {
            new CreateTriangle(3,4,5).GetTriangleType(),
            new CreateTriangle(5,6,7).GetTriangleType(),
            new CreateTriangle(7,7,7).GetTriangleType(),
            new CreateTriangle(7,7,9).GetTriangleType(),
            new SquareOrRectangle(7,7),
            new SquareOrRectangle(5,7),
        };

        foreach (Figure f in figures)
        {
            f.CalculateArea();
        }
    }
}