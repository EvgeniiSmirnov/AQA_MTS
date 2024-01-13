/*Задание 4: Задача: Учет книг в библиотеке
1. Создайте класс Book с полями:
Title (название книги), Author (автор книги), ISBN (уникальный идентификатор книги)
2. Создайте класс Reader с полями:
Name (имя читателя), LibraryCardNumber (номер библиотечной карты читателя)
3. Создайте класс Library, который будет содержать информацию о книгах и читателях, используя следующие структуры данных:
- List<Book> для хранения списка книг в библиотеке.
- Dictionary<Reader, ISet<Book>> для отслеживания, какие книги взяты у каждого читателя.
В качестве ключей вы используете объекты типа Reader, а значения - ISet<Book>, представляющий множество книг, взятых у соответствующего читателя.
4. Реализуйте методы в классе Library:
- AddBook(Book book): Добавляет книгу в список книг в библиотеке.
- CheckOutBook(Reader reader, Book book): Выдает книгу читателю. Если книга уже взята кем-то другим, выдает соответствующее сообщение.
- ReturnBook(Reader reader, Book book): Возвращает книгу в библиотеку.
5. Реализуйте методы для вывода информации о книгах в библиотеке и о том, какие книги взяты у каждого читателя.
*/

using Homework8Task4;

class Program
{
    public static void Main()
    {
        Library library = new();

        // экземпляры книг
        Book book1 = new("The Cherry Orchard", "Anton Chekhov", "123-abc");
        Book book2 = new("The Old Man and the Sea", "Ernest Miller Hemingway", "456-def");
        Book book3 = new("Dead Souls", "Nikolai Gogol", "789-ghk");
        Book book4 = new("Taras Bulba", "Nikolai Gogol", "987-khg");

        // читатели
        Reader reader1 = new("Alex Petrov", 121);
        Reader reader2 = new("Petr Alexov", 212);

        // добавим книги в библиотеку
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);
        library.AddBook(book4);

        // выведем список книг в библиотеке
        library.PrintLibraryBookList();
        Console.WriteLine();

        // выдаём читателю1 книги
        library.CheckOutBook(reader1, book1);
        library.CheckOutBook(reader1, book2);
        Console.WriteLine();

        // выдаём читателю2 книги
        library.CheckOutBook(reader2, book1); // ожидаем ошибку, т.к. книга уже выдана другому читателю
        library.CheckOutBook(reader2, book3);
        Console.WriteLine();

        // выведем список книг у читателей на руках
        library.PrintReadersListWithBookSet();
    }
}