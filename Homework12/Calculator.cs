namespace Homework12;

class Calculator
{
    /// <summary>
    /// Метод для деления целых чисел
    /// </summary>
    /// <param name="firstNumber"></param>
    /// <param name="secondNumber"></param>
    /// <returns></returns>
    /// <exception cref="DivideByZeroException"></exception>
    public static int Divide(int firstNumber, int secondNumber) => firstNumber / secondNumber;

    /// <summary>
    /// Метод для деления чисел с плавающей точкой
    /// </summary>
    /// <param name="firstNumber"></param>
    /// <param name="secondNumber"></param>
    /// <returns></returns>
    public static double Divide(double firstNumber, double secondNumber)
    {
        // при делении double на ноль получаем бесконечность, поэтому такие случаи сведём к эксепшену
        if (double.IsInfinity(firstNumber / secondNumber)) throw new DivideByZeroException();
          return firstNumber / secondNumber;
    } 
}