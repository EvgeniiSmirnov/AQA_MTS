namespace Homework7Task1.Exceptions;

internal class WrongPasswordException : Exception
{
    // по условию задания нужен конструктор по умолчанию
    public WrongPasswordException() { }

    public WrongPasswordException(string message) : base(message) { }
}