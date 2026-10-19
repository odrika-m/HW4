using System;

class Program
{
    static decimal PlatinumToUSD(decimal ounces)
    {
        return ounces * 1634.00m;
    }

    static void Main()
    {
        Console.Write("Enter the number of ounces of platinum: ");
        decimal platinumOunces = Convert.ToDecimal(Console.ReadLine());

        decimal totalUSD = PlatinumToUSD(platinumOunces);

        Console.WriteLine($"Value in USD: {totalUSD:C2}");
    }
}