/*Задание 1
Напишите программу - консольный калькулятор.
UseCase:
1. 	Пользователь запускает программу
2. 	В терминале предлагается ввести число номер 1 – пользователь вводит число номер 1
3. 	В терминале предлагается ввести допустимую операцию (+, -, *, /) – пользователь вводит операцию
4. 	В терминале предлагается ввести число номер 2 – пользователь вводит число номер 2
5. 	В терминал выводится результат выбранной операции
Примечание:
·  	Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch.
·  	В случае использования операции деления, организуйте проверку попытки деления на ноль с выводом соответствующего сообщения
*/

Console.WriteLine("Введите первое число:");
var firstNum = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите символ желаемой операции (+, -, *, /):");
var operation = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Введите второе число:");

double secondNum;
bool flag;
do
{
    secondNum = Convert.ToDouble(Console.ReadLine());
    if (secondNum == 0)
    {
        Console.WriteLine("Второе число равно нулю. Введите другое число");
        flag = false;
    }
    else
    {
        flag = true;
    }
} while (flag == false);

var answerForm = "Ответ равен ";
do
{
    switch (operation)
    {
        case '+':
            Console.WriteLine(answerForm + (firstNum + secondNum)); flag = true; break;
        case '-':
            Console.WriteLine(answerForm + (firstNum - secondNum)); flag = true; break;
        case '*':
            Console.WriteLine(answerForm + firstNum * secondNum); flag = true; break;
        case '/':
            Console.WriteLine(answerForm + firstNum / secondNum); flag = true; break;
        default:
            Console.WriteLine("Введён неизвестный символ. Введите символ операции ещё раз (+, -, *, /):");
            operation = Convert.ToChar(Console.ReadLine());
            flag = false; break;
    }
} while (flag == false);