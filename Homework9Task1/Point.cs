namespace Homework9Task1;

internal class Point<T>
{
    private T _x;
    private T _y;
    public T X { get => _x; set => _x = value; }
    public T Y { get => _y; set => _y = value; }

    public Point(T x, T y)
    {
        _x = x;
        _y = y;
    }

    public void Print() => Console.WriteLine($"({_x}, {_y})");
}