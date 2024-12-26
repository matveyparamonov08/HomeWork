using System.Collections.Generic;
using System;
public class PaymentMethod
{
    public virtual void MakePayment(double amount)
    {
        Console.WriteLine("Оплата выполнена базовым методом оплаты.");
    }

}

public class CreditCard : PaymentMethod
{
    private string CardNumber;
    private string CardHolderName;

    public CreditCard(string cardNumber, string cardHolderName)
    {
        CardNumber = cardNumber;
        CardHolderName = cardHolderName;
    }

    public override void MakePayment(double amount)
    {
        Console.WriteLine($"Оплата {amount} выполнена с помощью кредитной карты {CardHolderName} (Номер: {CardNumber}).");
    }
}

// Класс для оплаты с помощью электронного кошелька
public class EWallet : PaymentMethod
{
    private string WalletId;

    public EWallet(string walletId)
    {
        WalletId = walletId;
    }

    public override void MakePayment(double amount)
    {
        Console.WriteLine($"Оплата {amount} выполнена с помощью электронного кошелька {WalletId}.");
    }
}

// Класс для оплаты с помощью банковского перевода
public class BankTransfer : PaymentMethod
{
    private string BankAccount;

    public BankTransfer(string bankAccount)
    {
        BankAccount = bankAccount;
    }

    public override void MakePayment(double amount)
    {
        Console.WriteLine($"Оплата {amount} выполнена с помощью банковского перевода (Счет: {BankAccount}).");
    }
}

// Пример использования
class Program
{
    static void Main(string[] args)
    {
        PaymentMethod payment;

        // Оплата с использованием кредитной карты
        payment = new CreditCard("1234-5678-9876-5432", "Иван Иванов");
        payment.MakePayment(1500.75);

        // Оплата с использованием электронного кошелька
        payment = new EWallet("wallet12345");
        payment.MakePayment(500);

        // Оплата с использованием банковского перевода
        payment = new BankTransfer("RU1234567890");
        payment.MakePayment(2500);
    }
}
