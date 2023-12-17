using Homework6Task3.Documents;

namespace Homework6Task3.Register;

// Создать класс Регистр, который будет иметь методы: сохранения документа в регистре, предоставление информации о документе
public class Register : IRegisterAdd, IRegisterGet
{
    Document[] documentsArray = new Document[10];

    // метод сохранения (добавления) документа в регистр
    public void AddDocument(Document document)
    {
        for (byte i = 0; i < documentsArray.Length; i++)
        {
            // проверяем элементы массива, если не пусто скипаем, если дошли до последнего элемента и не пусто, то заполнен
            if (documentsArray[i] != null)
            {
                if (i == documentsArray.Length - 1)
                {
                    Console.WriteLine("Не удалось добавить. Регистр документов заполнен");
                    break;
                }
                continue;
            }

            if (documentsArray[i] == null) // если пустой, то заполняем
            {
                documentsArray[i] = document;

                break;
            }
        }
    }

    // метод вывода информации о документе из регистра (при наличии)
    public void GetDocumentInfoFromRegister(Document document)
    {
        if (documentsArray.Contains(document))
        {
            document.PrintDocumentInfo();
        }
        else
        {
            Console.WriteLine("В регистре нет запрашиваемого документа");
        }
    }

    // метод выводит список документов в регистре
    public void GetRegisterDocuments()
    {
        byte counter = 0;
        bool flag = true;
        // проходим по всему массиву, если нет не пустых элементов то массив (регистр) пуст
        for (byte i = 0; i < documentsArray.Length; i++)
        {
            if (documentsArray[i] == null)
            {
                counter++;
                if (counter == documentsArray.Length)
                {
                    Console.WriteLine("В регистре нет документов.");
                    flag = false;
                }
            }
        }
        // в эту ветку идём при наличии хоть одного документа в массиве (регистре)
        if (flag)
        {
            Console.WriteLine("Документы в регистре:");
            foreach (Document e in documentsArray)
            {
                if (e != null)
                {
                    e.PrintDocumentInfo();
                }
                Console.WriteLine();
            }
        }
    }
}