/*Задание 4:
Даны две последовательности:
- Список сотрудников [Фамилия, Специальность]
- Ведомость зарплаты сотрудников [Фамилия, ЗП]

Необходимо, посчитать общую сумму зарплат по специальностям.
*/

using Homework11Task4;

class Programm
{
    public static void Main()
    {
        List<PersonPosition> personPositionList =
    [
        new PersonPosition("Петров", "QA"),
        new PersonPosition("Иванов", "AQA"),
        new PersonPosition("Сидоров", "Developer"),
        new PersonPosition("Михайлова", "HR"),
        new PersonPosition("Смирнова", "QA"),
        new PersonPosition("Быстрова", "AQA")
    ];

        List<SalaryRate> salaryRateList =
    [
        new SalaryRate("Петров", 70000),
        new SalaryRate("Иванов", 80000),
        new SalaryRate("Сидоров", 90000),
        new SalaryRate("Михайлова", 70000),
        new SalaryRate("Смирнова", 100000),
        new SalaryRate("Быстрова", 110000)
    ];

        // объединяем по ключю фамилии, группируем по позиции, пересобираем выборку с суммированием зп
        var salarySumByPosition =
            from person in personPositionList
            join salary in salaryRateList on person.Surname equals salary.Surname
            group new { person, salary } by person.Position into grp
            select new { Position = grp.Key, Salary = grp.Sum(x => x.salary.Salary) };

        // вывод элементов выборки в консоль
        foreach (var i in salarySumByPosition) Console.WriteLine($"{i.Position} {i.Salary}");
    }
}