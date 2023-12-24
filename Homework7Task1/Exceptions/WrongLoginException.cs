namespace Homework7Task1.Exceptions;

internal class WrongLoginException : Exception
{
    // по условию задания нужен конструктор по умолчанию
    public WrongLoginException() { }

    public WrongLoginException(string message) : base(message) { }
}