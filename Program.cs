// See https://aka.ms/new-console-template for more information

using BankEncapsulation;

BankAccount account = new BankAccount();

Console.WriteLine("How much would you like to deposit?");

var amountToDeposit= double.Parse(Console.ReadLine());

account.Deposit(amountToDeposit);

Console.WriteLine($"Thank you your balance is now {account.GetBalance()}");