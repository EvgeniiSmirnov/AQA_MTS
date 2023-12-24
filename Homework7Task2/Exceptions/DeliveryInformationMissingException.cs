namespace Homework7Task2.Exceptions;

internal class DeliveryInformationMissingException : Exception
{
    public DeliveryInformationMissingException(string message) : base(message) { }
}