// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Clothing Store Checkout System!");

        int trousers = GetQuantity("trousers");
        int tShirts = GetQuantity("T-shirts");
        int vests = GetQuantity("vests");

        double totalCost = (trousers * 70.5) + (tShirts * 20.89) + (vests * 100.3);

        Console.WriteLine($"The total payable amount is: {totalCost:F2} EUR");
    }

    static int GetQuantity(string item)
    {
        int quantity;
        Console.Write($"Enter the number of {item} purchased: ");
        while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0)
        {
            Console.Write($"Please enter a valid non-negative number for {item}: ");
        }
        return quantity;
    }
}

