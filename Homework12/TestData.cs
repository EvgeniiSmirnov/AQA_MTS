namespace Homework12;

internal class TestData
{
    // данные для проверки деления целых чисел
    public static object[] ItegerDivideCases =
    {
        new object[] { 15, 3, 5 },
        new object[] { -15, 3, -5},
        new object[] { -15, -3, 5},
        new object[] { 15, 5, 3 },
        new object[] { 15, 15, 1 },
        new object[] { 15, 1, 15},
        new object[] { 16, 3, 5 },
        new object[] { 16, 5, 3 }
    };

    // данные для проверки деления чисел с плавающей точкой
    public static object[] DoubleDivideCases =
    {
        new object[] { 1.0, 2.0, 0.5 },
        new object[] { -1.0, 2.0, -0.5 },
        new object[] { -1.0, -2.0, 0.5 },
        new object[] { 10.10, 5.0, 2.02 },
    };
}