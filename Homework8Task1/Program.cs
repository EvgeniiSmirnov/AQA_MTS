/*Задание 1:
Напишите программу, используя ArrayList, чтобы хранить информацию о книгах в библиотеке.
Ваша программа должна предоставлять следующие функциональности:
1. Добавление книги: Пользователь может вводить информацию о новой книге, включая название, автора и год издания.
Эта информация должна быть добавлена в ArrayList.
2. Отображение списка книг: Пользователь может просматривать список всех книг в библиотеке, включая название, автора и год издания.
3. Поиск книги по автору: Пользователь может ввести имя автора, и программа должна отобразить список книг этого автора.
4. Удаление книги: Пользователь может выбрать книгу из списка и удалить ее из библиотеки.
5. Выход из программы: Пользователь может завершить программу.
*/

using Homework8Task1;

class Program
{
    public static void Main()
    {
        // добавим в библиотеку несколько книг использую метод AddBook
        Library library = new();
        Book bookExample = new("The Cherry Orchard", "Anton Chekhov", 1904);

        library.AddBook(new Book("The Old Man and the Sea", "Ernest Miller Hemingway", 1952));
        library.AddBook(new Book("Dead Souls", "Nikolai Gogol", 1842));
        library.AddBook(new Book("Taras Bulba", "Nikolai Gogol", 1835));
        library.AddBook(bookExample);

        // выведем информацию о всех книгах в библиотеке
        library.PrintLibraryInfo();

        // выведем информацию о всех книгах в библиотеке заданного автора
        Console.WriteLine();
        library.PrintBooksByAuthor("Nikolai Gogol");
        library.PrintBooksByAuthor("12345");

        // удалим книгу и выведем список книг в библиотеке ещё раз
        library.DeleteBook(bookExample);
        Console.WriteLine();
        library.PrintLibraryInfo();

        // завершение программы
        Console.WriteLine();
        Library.Exit();
    }
}