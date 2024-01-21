namespace Homework10Task2;

internal class GeometricFormulas
{
    const double PI = Math.PI;

    /// <summary>
    /// Метод для рассчёта длины окружности
    /// </summary>
    /// <param name="radius"></param>
    /// <returns></returns>
    public double GetCircleLength(double radius) => 2 * PI * radius;

    /// <summary>
    /// Метод для рассчёта площади круга
    /// </summary>
    /// <param name="radius"></param>
    /// <returns></returns>
    public double GetCircleSquare(double radius) => PI * Math.Pow(radius, 2);

    /// <summary>
    /// Метод для рассчёта объёма шара
    /// </summary>
    /// <param name="radius"></param>
    /// <returns></returns>
    public double GetSphereVolume(double radius) => PI * Math.Pow(radius, 3) * 4 / 3;
}