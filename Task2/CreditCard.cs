namespace Task2;

public class CreditCard
{
    public string accountNumber;
    private double currentAmountOfAccount;

    public CreditCard(string accountNumber)
    {
        this.accountNumber = accountNumber;
        currentAmountOfAccount = 0;
    }

    public CreditCard(string accountNumber, double currentAmountOfAccount) : this (accountNumber)
    {
        this.accountNumber = accountNumber;
        this.currentAmountOfAccount = currentAmountOfAccount;
    }

    // метод позволяет зачислять сумму на кредитную карту
    public void AddAmount(double amount) => currentAmountOfAccount += amount;

    // метод позволяет снимать некоторую сумму с карты
    public void TakeAmount(double amount)
    {
        if (currentAmountOfAccount >= amount)
        {
            currentAmountOfAccount -= amount;
        }
        else
        {
            Console.WriteLine($"На счёте недостаточно денежных средств. Баланс: {currentAmountOfAccount}");
        }
    }

    // метод выводит текущую информацию о карточке
    public void GetInfo()
    {
        Console.WriteLine($"Номер счета: {this.accountNumber}\nБаланс: {this.currentAmountOfAccount}");
    }
}
