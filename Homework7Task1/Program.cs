/*Задание 1:
Создать класс, в котором будет статический метод. Этот метод принимает на вход три параметра:
login, password, confirmPassword.

Все поля имеют тип данных String.
- Длина login должна быть меньше 20 символов и не должен содержать пробелы.
- Если login не соответствует этим требованиям, необходимо выбросить WrongLoginException.
- Длина password должна быть меньше 20 символов, не должен содержать пробелом и должен содержать хотя бы одну цифру.
- Также password и confirmPassword должны быть равны.
- Если password не соответствует этим требованиям, необходимо выбросить WrongPasswordException.

WrongPasswordException и WrongLoginException - пользовательские классы исключения с двумя конструкторами – один по умолчанию,
второй принимает сообщение исключения и передает его в конструктор класса Exception.
Метод возвращает true, если все значения верны или false в другом случае.
*/

using Homework7Task1;

public class Program
{
    public static void Main()
    {
        // для проверки создадим массив с различными входными данными
        bool[] test =
        {
            // негативные проверки логина
            LoginPassword.CheckLoginPassData("", "123", "123"),
            LoginPassword.CheckLoginPassData("alex ", "123", "123"),
            LoginPassword.CheckLoginPassData("alexalexalexalexalexalexalex", "123", "123"),

            // негативные проверки пароля
            LoginPassword.CheckLoginPassData("alex", "", "123"),
            LoginPassword.CheckLoginPassData("alex", "123 ", "123"),
            LoginPassword.CheckLoginPassData("alex", "alex", "123"),
            LoginPassword.CheckLoginPassData("alex", "124", "123"),

            // позитивная проверка
            LoginPassword.CheckLoginPassData("alex", "123", "123")
        };

        for (int i = 0; i < test.Length; i++)
        {
            Console.Write($"test {i}: ");
            if (!test[i])
            {
                Console.WriteLine("Данные не приняты");
            }
            else
            {
                Console.WriteLine("Данные приняты");
            };
        }
    }
}