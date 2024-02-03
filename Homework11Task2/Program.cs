/*Задание 2:
Исходная последовательность содержит сведения о клиентах фитнес-центра.
Каждый элемент последовательности включает следующие целочисленные поля:
<Код клиента>; <Год>; <Номер месяца>; <Продолжительность занятий (в часах)>; 

Найти элемент последовательности с минимальной продолжительностью занятий.
Вывести эту продолжительность, а также соответствующие ей год и номер месяца (в указанном порядке на той же строке). 
Если имеется несколько элементов с минимальной продолжительностью, то вывести данные того из них,
который является последним в исходной последовательности.
*/

using Homework11Task2;
class Programm
{
    public static void Main()
    {
        List<Client> clientList =
            [
                new Client(1, 2023, 11, 5),
                new Client(1, 2023, 12, 10),
                new Client(2, 2023, 8, 15),
                new Client(3, 2023, 3, 5),
                new Client(4, 2023, 7, 20)
            ];

        var lastMinimalTrainingHours = clientList.OrderByDescending(c => c.TrainingHours).Last();

        Console.WriteLine($"Продолжительность занятий (в часах): {lastMinimalTrainingHours.TrainingHours}, год: {lastMinimalTrainingHours.Year}, номер месяца: {lastMinimalTrainingHours.Month}");

        //var clientQuery =
        //    (from client in clientList
        //    group client by client.TrainingHours into result
        //    orderby result.Key descending
        //    select new { TrainingHours = result.Key }).Last();
        //Console.WriteLine(clientQuery.TrainingHours);
    }
}