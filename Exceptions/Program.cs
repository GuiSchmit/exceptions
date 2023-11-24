using Exceptions.Entities;
using System.Globalization;
using Exceptions.Entities.Exceptions;

try
{
    Console.WriteLine("Enter account data:");
    Console.WriteLine("");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    Console.Write("Initial balance: $");
    double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Withdraw limit: $");
    double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Account acc = new Account(number, holder, balance, withdrawLimit);

    Console.Write("Enter the amount for withdraw: $");
    double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("");

    acc.Withdraw(amount);

    Console.WriteLine(acc);
}
catch (DomainException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Unexpected error: " + e.Message);
}