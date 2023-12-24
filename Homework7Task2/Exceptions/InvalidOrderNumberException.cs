namespace Homework7Task2.Exceptions;

internal class InvalidOrderNumberException : Exception
{
    public InvalidOrderNumberException(string message) : base(message) { }
}