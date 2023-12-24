using Homework7Task1.Exceptions;
using System.Text.RegularExpressions;

namespace Homework7Task1;

internal class LoginPassword
{
    private static string Login { get; set; }

    private static string Password { get; set; }

    private static string ConfirmPassword { get; set; }

    public static bool CheckLoginPassData(string login, string password, string confirmPassword)
    {
        Login = login;
        Password = password;
        ConfirmPassword = confirmPassword;

        try
        {
            // ветка проверки логина
            // длина login должна быть меньше 20 символов и не должен содержать пробелы
            if (string.IsNullOrEmpty(Login))
            {
                throw new WrongLoginException("Ошибка! login не задан");
            }
            else if (Login.Contains(' '))
            {
                throw new WrongLoginException("Ошибка! login содержит пробелы");
            }
            else if (Login.Length >= 20)
            {
                throw new WrongLoginException("Ошибка! Длина login должна быть меньше 20 символов");
            }

            // если с логином всё хорошо пападаем в ветку проверки пароля
            // длина password должна быть меньше 20 символов, не должен содержать пробелом и должен содержать хотя бы одну цифру
            else
            {
                Regex regex = new(@"^\d+$");
                if (string.IsNullOrEmpty(Password))
                {
                    throw new WrongPasswordException("Ошибка! password не задан");
                }
                else if (Password.Contains(' '))
                {
                    throw new WrongPasswordException("Ошибка! password содержит пробелы");
                }
                else if (Password.Length >= 20)
                {
                    throw new WrongPasswordException("Ошибка! Длина password должна быть меньше 20 символов");
                }
                else if (!regex.IsMatch(Password))
                {
                    throw new WrongPasswordException("Ошибка! password должен содержать хотя бы одну цифру");
                }
                else if (!Password.Equals(ConfirmPassword))
                {
                    throw new WrongPasswordException("Ошибка! password не совпадает с confirmPassword");
                }

                return true;
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }
}