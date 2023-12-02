namespace Task3;

public class ATM
{
    int banknote20;
    int banknote50;
    int banknote100;

    public ATM(int banknote20, int banknote50, int banknote100)
    {
        this.banknote20 = banknote20;
        this.banknote50 = banknote50;
        this.banknote100 = banknote100;
    }

    // метод для добавления денег в банкомат
    public void AddAmount(int amount, int banknote)
    {
        Console.WriteLine("Внесите денежные средства.\n" +
            "Банкомат принимает купюры номиналом: 20, 50 ,100");
        if (amount <= 0)
        {
            Console.WriteLine("Количество купюр должно быть больше нуля");
        }
        else
        {
            switch (banknote)
            {
                case 20:
                    this.banknote20 += amount;
                    break;
                case 50:
                    this.banknote50 += amount;
                    break;
                case 100:
                    this.banknote100 += amount;
                    break;
                default:
                    Console.WriteLine("Купюра не распознана");
                    break;
            }
        }
    }

    // для снятия денег - возвращает булевое значение - успешность выполнения операции
    public bool TakeAmount(int amount, int banknote)
    {

        if (amount <= 0)
        {
            Console.WriteLine("Количество купюр должно быть больше нуля");
            return false;
        }
        else
        {
            switch (banknote)
            {
                case 20:
                    if (banknote20 < amount)
                    {
                        Console.WriteLine("В банкомате недостаточно купюр требуемого номинала.");
                        return false;
                    }
                    else
                    {
                       this.banknote20 -= amount;
                        return true;
                    }
                case 50:
                    if (banknote50 < amount)
                    {
                        Console.WriteLine("В банкомате недостаточно купюр требуемого номинала.");
                        return false;
                    }
                    else
                    {
                        this.banknote50 -= amount;
                        return true;
                    }
                case 100:
                    if (banknote100 < amount)
                    {
                        Console.WriteLine("В банкомате недостаточно купюр требуемого номинала.");
                        return false;
                    }
                    else
                    {
                        this.banknote100 -= amount;
                        return true;
                    }
                default:
                    Console.WriteLine("Купюра не распознана");
                    return false;
            }
        }
    }

    // метод выводит какими купюрами и в каком количестве выдаётся сумма
    public void PrintTakeAmountInfo(int amount, int banknote)
    {

        if (TakeAmount(amount, banknote))
        {
            Console.WriteLine($"Сумма к выдаче: {banknote * amount}, купюры: {banknote}");
        }
    }

}
